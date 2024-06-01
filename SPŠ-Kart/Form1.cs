namespace SPŠ_Kart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Settings = new Settings();
            Settings.ShowDialog();
            this.Close();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int SetLang;
            int BestScore;
            int DevEnabled;
            this.BackgroundImage = Properties.Resources.Runway_BG;
            using (StreamReader sr = new StreamReader("Settings.json"))
            {
                int.TryParse(sr.ReadLine(), out SetLang);
                int.TryParse(sr.ReadLine(), out BestScore);
                int.TryParse(sr.ReadLine(), out DevEnabled);

            }

            if (SetLang == 1)
            {
                lb_Debug.Text = "EN";
                lb_InfoFire.Text = "Spacebar for jump \nArrow Up for Gas  \nArrow down for break";
                this.Text = ($"SPŠ-Kart | Best score: {BestScore}");
            }
            if (SetLang == 2)
            {
                lb_Debug.Text = "CZ";
                btn_Play.Text = "Hrát";
                btn_Settings.Text = "Nastavení";
                btn_Quit.Text = "Konec";
                lb_InfoFire.Text = "Mezerník pro skok \nŠipka nahoru pro plyn \nŠipka dolů pro brzdu";
                this.Text = ($"SPŠ-Kart | Nejlepší skóre: {BestScore}");

            }
            else { }
            if (DevEnabled == 0) lb_Debug.Visible = false;
            else { }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form GamePlay = new GamePlay();
            GamePlay.ShowDialog();
            this.Close();
        }


    }
}
