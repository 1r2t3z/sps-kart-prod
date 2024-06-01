namespace SPŠ_Kart
{
    partial class GamePlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            lb_Debug = new Label();
            btn_GoHome = new Button();
            lb_playerSpeed = new Label();
            SuspendLayout();
            // 
            // lb_Debug
            // 
            lb_Debug.AutoSize = true;
            lb_Debug.BackColor = Color.Yellow;
            lb_Debug.Location = new Point(1396, 14);
            lb_Debug.Margin = new Padding(5, 0, 5, 0);
            lb_Debug.Name = "lb_Debug";
            lb_Debug.Size = new Size(78, 32);
            lb_Debug.TabIndex = 1;
            lb_Debug.Text = "label1";
            // 
            // btn_GoHome
            // 
            btn_GoHome.BackColor = Color.Yellow;
            btn_GoHome.Enabled = false;
            btn_GoHome.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GoHome.Location = new Point(674, 725);
            btn_GoHome.Margin = new Padding(5);
            btn_GoHome.Name = "btn_GoHome";
            btn_GoHome.Size = new Size(232, 133);
            btn_GoHome.TabIndex = 3;
            btn_GoHome.Text = "Home";
            btn_GoHome.UseVisualStyleBackColor = false;
            btn_GoHome.Visible = false;
            btn_GoHome.Click += btn_GoHome_Click;
            // 
            // lb_playerSpeed
            // 
            lb_playerSpeed.AutoSize = true;
            lb_playerSpeed.BackColor = Color.Yellow;
            lb_playerSpeed.Font = new Font("Segoe UI Black", 18.875F, FontStyle.Bold, GraphicsUnit.Point);
            lb_playerSpeed.Location = new Point(1274, 885);
            lb_playerSpeed.Margin = new Padding(5, 0, 5, 0);
            lb_playerSpeed.Name = "lb_playerSpeed";
            lb_playerSpeed.Size = new Size(177, 68);
            lb_playerSpeed.TabIndex = 4;
            lb_playerSpeed.Text = "label1";
            // 
            // GamePlay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1548, 1002);
            Controls.Add(lb_playerSpeed);
            Controls.Add(btn_GoHome);
            Controls.Add(lb_Debug);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "GamePlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPŠ-Kart";
            Load += GamePlay_Load;
            KeyDown += GamePlay_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Debug;
        private Button btn_GoHome;
        private Label lb_playerSpeed;
    }
}