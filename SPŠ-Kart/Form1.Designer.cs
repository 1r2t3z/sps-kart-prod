namespace SPŠ_Kart
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Play = new Button();
            btn_Settings = new Button();
            btn_Quit = new Button();
            lb_Debug = new Label();
            lb_InfoFire = new Label();
            SuspendLayout();
            // 
            // btn_Play
            // 
            btn_Play.BackColor = Color.Yellow;
            btn_Play.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Play.Location = new Point(52, 696);
            btn_Play.Margin = new Padding(5);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(538, 96);
            btn_Play.TabIndex = 0;
            btn_Play.Text = "Play";
            btn_Play.UseVisualStyleBackColor = false;
            btn_Play.Click += btn_Play_Click;
            // 
            // btn_Settings
            // 
            btn_Settings.BackColor = Color.Yellow;
            btn_Settings.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Settings.Location = new Point(52, 800);
            btn_Settings.Margin = new Padding(5);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(263, 96);
            btn_Settings.TabIndex = 1;
            btn_Settings.Text = "Settings";
            btn_Settings.UseVisualStyleBackColor = false;
            btn_Settings.Click += btn_Settings_Click;
            // 
            // btn_Quit
            // 
            btn_Quit.BackColor = Color.Yellow;
            btn_Quit.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Quit.Location = new Point(328, 800);
            btn_Quit.Margin = new Padding(5);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new Size(263, 96);
            btn_Quit.TabIndex = 2;
            btn_Quit.Text = "Quit";
            btn_Quit.UseVisualStyleBackColor = false;
            btn_Quit.Click += btn_Quit_Click;
            // 
            // lb_Debug
            // 
            lb_Debug.AutoSize = true;
            lb_Debug.BackColor = Color.Transparent;
            lb_Debug.ForeColor = Color.Yellow;
            lb_Debug.Location = new Point(1406, 14);
            lb_Debug.Margin = new Padding(5, 0, 5, 0);
            lb_Debug.Name = "lb_Debug";
            lb_Debug.Size = new Size(78, 32);
            lb_Debug.TabIndex = 3;
            lb_Debug.Text = "label1";
            // 
            // lb_InfoFire
            // 
            lb_InfoFire.AutoSize = true;
            lb_InfoFire.BackColor = Color.Transparent;
            lb_InfoFire.ForeColor = Color.Yellow;
            lb_InfoFire.Location = new Point(1030, 783);
            lb_InfoFire.Margin = new Padding(5, 0, 5, 0);
            lb_InfoFire.Name = "lb_InfoFire";
            lb_InfoFire.Size = new Size(0, 32);
            lb_InfoFire.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Runway_BG;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1548, 1002);
            Controls.Add(lb_InfoFire);
            Controls.Add(lb_Debug);
            Controls.Add(btn_Quit);
            Controls.Add(btn_Settings);
            Controls.Add(btn_Play);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPŠ-Kart";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_Play;
        private Button btn_Settings;
        private Button btn_Quit;
        private Label lb_Debug;
        private Label lb_InfoFire;
    }
}