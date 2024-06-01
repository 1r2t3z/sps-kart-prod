using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPŠ_Kart
{
    public partial class GamePlay : Form
    {
        private List<Rectangle> trackSegments = new List<Rectangle>();
        private List<(PictureBox obstacle, string type)> obstacles = new List<(PictureBox obstacle, string type)>();
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private const int TrackSpeedIncreaseInterval = 250;
        private const int InitialTrackSpeed = 15;
        private const int SegmentWidth = 500;
        private const int SegmentHeight = 150;
        private const int MaxPlayerSpeed = 40;
        private const int InitialJumpSpeed = 20;
        private const int Gravity = 1;
        private const int GroundOffset = 275;
        private int trackSpeed = InitialTrackSpeed;
        private int playerSpeed = 0;
        private int score = 0;
        private Random random = new Random();
        private bool isGameOver = false;
        private int backgroundIndex = 0;
        private Image[] backgrounds;
        private bool isJumping = false;
        private int jumpSpeed = 0;
        private int groundLevel;
        private bool colided = false;

        public GamePlay()
        {
            InitializeComponent();
            LoadBackgrounds();
        }

        private string finalScoreText;
        private string finalText;

        private void LoadBackgrounds()
        {
            backgrounds = new Image[]
            {
                Properties.Resources.bg1,
                Properties.Resources.bg2,
                Properties.Resources.bg3
            };
            this.BackgroundImage = backgrounds[backgroundIndex];
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private int bestScore;
        private int setLang;
        private int devEnabled;

        private void GamePlay_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Settings.json"))
                {
                    int.TryParse(sr.ReadLine(), out setLang);
                    int.TryParse(sr.ReadLine(), out bestScore);
                    int.TryParse(sr.ReadLine(), out devEnabled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
            }

            InitializeLocalization();
            if (devEnabled == 0) lb_Debug.Visible = false;

            InitializeGame();
        }

        private string DebugLang;

        private void InitializeLocalization()
        {
            if (setLang == 1)
            {

                DebugLang = "EN";
                finalScoreText = "Final score is ";
                finalText = "Game over, try again!";
            }
            else if (setLang == 2)
            {
                DebugLang = "CZ";
                finalScoreText = "Finální skóre je ";
                btn_GoHome.Text = "Zpět domů";
                finalText = "Prohrál jsi, zkus to znovu!";
            }
        }

        private void InitializeGame()
        {
            this.DoubleBuffered = true;

            // Create the player PictureBox
            player = new PictureBox
            {
                Image = Properties.Resources.bike_type1,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(75, 75),
                BackColor = Color.Transparent,
                Location = new Point(this.Width / 2 - 37, this.Height - GroundOffset)
            };
            this.Controls.Add(player);
            groundLevel = this.Height - GroundOffset;

            for (int i = 0; i < 5; i++)
            {
                AddNewTrackSegment();
            }

            gameTimer.Interval = 33; // Roughly 30 FPS
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void AddNewTrackSegment()
        {
            if (trackSegments.Count > 0)
            {
                var lastSegment = trackSegments.Last();
                var newSegment = new Rectangle(lastSegment.X + lastSegment.Width, this.Height - 200, SegmentWidth, this.Height);
                trackSegments.Add(newSegment);

                if (random.Next(3) == 0) // 33% chance
                {
                    AddObstacle(newSegment);
                }
            }
            else
            {
                var newSegment = new Rectangle(this.Width, this.Height - 200, SegmentWidth, this.Height);
                trackSegments.Add(newSegment);
            }
        }

        private void AddObstacle(Rectangle segment)
        {
            var obstacleType = random.Next(10) < 6 ? "cone" : (random.Next(2) == 0 ? "slow" : "barrier");
            var obstacle = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            if (obstacleType == "slow")
            {
                obstacle.Image = Properties.Resources.policecar;
                obstacle.Size = new Size(150, 75);
                obstacle.Location = new Point(segment.X + random.Next(50, 150), this.Height - GroundOffset);
            }
            else if (obstacleType == "barrier")
            {
                obstacle.Image = Properties.Resources.fire;
                obstacle.Size = new Size(100, 100);
                obstacle.Location = new Point(segment.X + random.Next(50, 150), this.Height - 300);
            }
            else if (obstacleType == "cone")
            {
                obstacle.Image = Properties.Resources.cone;
                obstacle.Size = new Size(75, 75);
                obstacle.Location = new Point(segment.X + random.Next(50, 150), this.Height - GroundOffset);
            }

            this.Controls.Add(obstacle);
            obstacles.Add((obstacle, obstacleType));
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            score++;

            if (score % TrackSpeedIncreaseInterval == 0)
            {
                ChangeBackground();
                trackSpeed += 5;
            }

            MoveTrackAndObstacles();
            CheckCollisions();
            UpdatePlayerPosition();

            lb_Debug.Text = (DebugLang + "\n" + isJumping + "\n" + isGameOver + "\n" + backgroundIndex + "\n" + colided);

            if (player.Left < 0 || player.Right > this.Width)
            {
                EndGame();
            }
            else
            {
                Invalidate(); // Refresh the form to update the game state
            }
        }

        private void ChangeBackground()
        {
            backgroundIndex = (backgroundIndex + 1) % backgrounds.Length;
            this.BackgroundImage = backgrounds[backgroundIndex];
        }

        private void MoveTrackAndObstacles()
        {
            for (int i = 0; i < trackSegments.Count; i++)
            {
                var segment = trackSegments[i];
                segment.X -= trackSpeed;
                trackSegments[i] = segment;
            }

            for (int i = 0; i < obstacles.Count; i++)
            {
                var obstacle = obstacles[i];
                obstacle.obstacle.Left -= trackSpeed;
            }

            if (trackSegments[0].Right <= 0)
            {
                trackSegments.RemoveAt(0);
                AddNewTrackSegment();
            }
        }


        private void HandleFireCollision()
        {
            //nefunguje 😢
            if (playerSpeed > 20)
            {
                playerSpeed = 40;

            }
            else { }
        }

        private void HandlePoliceCarCollision()
        {
            if (playerSpeed > 10)
            {
                playerSpeed = 10;
            }
            else
            {
                if(colided==false)
                {
                    score += 5;
                    colided = true;
                }
                else{}
                
            }
        }

        private void CheckCollisions()
        {
            foreach (var obstacle in obstacles)
            {
                if (player.Bounds.IntersectsWith(obstacle.obstacle.Bounds))
                {
                    if (obstacle.type == "barrier")
                    {
                        HandleFireCollision();
                    }
                    else if (obstacle.type == "slow")
                    {
                        HandlePoliceCarCollision();
                    }
                    else if (obstacle.type == "cone")
                    {
                        isGameOver = true;
                        gameTimer.Stop();
                    }
                }
                else
                {
                    colided = false;
                }
            }
        }


        private void UpdatePlayerPosition()
        {
            if (isJumping)
            {
                player.Top -= jumpSpeed;
                jumpSpeed -= Gravity;

                // Update horizontal position during jump
                player.Left -= playerSpeed;

                if (player.Top >= groundLevel)
                {
                    player.Top = groundLevel;
                    isJumping = false;
                    jumpSpeed = 0;
                }
            }
            else
            {
                player.Left -= playerSpeed;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!isGameOver)
            {
                foreach (var segment in trackSegments)
                {
                    int shade = random.Next(30, 60); // Range for different shades
                    Brush segmentBrush = new SolidBrush(Color.FromArgb(shade, shade, shade));
                    e.Graphics.FillRectangle(segmentBrush, segment);
                }

                e.Graphics.DrawString(finalScoreText + score, this.Font, Brushes.White, 10, 10);
                lb_playerSpeed.Text = $"{Math.Abs(playerSpeed - 45)} km/h";
            }
            else
            {
                DisplayGameOverScreen(e);
            }
        }

        private void DisplayGameOverScreen(PaintEventArgs e)
        {
            string gameOverText = finalText;
            string scoreText = score.ToString();
            Font gameOverFont = new Font(this.Font.FontFamily, 24, FontStyle.Regular);
            Font scoreFont = new Font(this.Font.FontFamily, 18, FontStyle.Regular);
            SizeF gameOverSize = e.Graphics.MeasureString(gameOverText, gameOverFont);
            SizeF scoreSize = e.Graphics.MeasureString(scoreText, scoreFont);

            PointF gameOverPosition = new PointF((this.Width - gameOverSize.Width) / 2, (this.Height - gameOverSize.Height) / 2);
            PointF scorePosition = new PointF((this.Width - scoreSize.Width) / 2, (this.Height - scoreSize.Height) / 2 + 65);

            e.Graphics.DrawString(gameOverText, gameOverFont, Brushes.White, gameOverPosition);
            e.Graphics.DrawString(scoreText, scoreFont, Brushes.White, scorePosition);
            btn_GoHome.Enabled = true;
            btn_GoHome.Visible = true;

            if (score >= bestScore)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter("Settings.json"))
                    {
                        sw.WriteLine(setLang);
                        sw.WriteLine(score);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving score: " + ex.Message);
                }
            }
        }

        private void EndGame()
        {
            btn_GoHome.Enabled = true;
            btn_GoHome.Visible = true;
            isGameOver = true;
            gameTimer.Stop();
            Invalidate(); // Refresh the form to display the game over message and score
        }

        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            //Key up and down
            if (e.KeyCode == Keys.Up)
            {
                playerSpeed = Math.Min(MaxPlayerSpeed, playerSpeed - 1);
            }
            else if (e.KeyCode == Keys.Down)
            {
                playerSpeed = playerSpeed + 1;
            }

            //W and S
            else if (e.KeyCode == Keys.W)
            {
                playerSpeed = Math.Min(MaxPlayerSpeed, playerSpeed - 1);
            }
            else if (e.KeyCode == Keys.S)
            {
                playerSpeed = playerSpeed + 1;
            }

            else if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                jumpSpeed = InitialJumpSpeed;
            }
        }


        private void btn_GoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new Form1();
            main.ShowDialog();
            this.Close();
        }
    }
}
