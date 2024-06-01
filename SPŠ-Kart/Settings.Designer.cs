namespace SPŠ_Kart
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            lb_Settings = new Label();
            btn_Back = new Button();
            cmb_Language = new ComboBox();
            lb_Language = new Label();
            lb_Debug = new Label();
            lb_Info = new Label();
            lb_Dev = new Label();
            chbDev = new CheckBox();
            btn_ResetBest = new Button();
            SuspendLayout();
            // 
            // lb_Settings
            // 
            lb_Settings.AutoSize = true;
            lb_Settings.BackColor = Color.Transparent;
            lb_Settings.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Settings.ForeColor = Color.Yellow;
            lb_Settings.Location = new Point(20, 77);
            lb_Settings.Margin = new Padding(5, 0, 5, 0);
            lb_Settings.Name = "lb_Settings";
            lb_Settings.Size = new Size(296, 86);
            lb_Settings.TabIndex = 0;
            lb_Settings.Text = "Settings";
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Yellow;
            btn_Back.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(14, 885);
            btn_Back.Margin = new Padding(5);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(170, 62);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // cmb_Language
            // 
            cmb_Language.BackColor = Color.Yellow;
            cmb_Language.ForeColor = Color.Black;
            cmb_Language.FormattingEnabled = true;
            cmb_Language.Location = new Point(83, 249);
            cmb_Language.Margin = new Padding(5);
            cmb_Language.Name = "cmb_Language";
            cmb_Language.Size = new Size(319, 40);
            cmb_Language.TabIndex = 2;
            cmb_Language.SelectedIndexChanged += cmb_Language_SelectedIndexChanged;
            // 
            // lb_Language
            // 
            lb_Language.AutoSize = true;
            lb_Language.BackColor = Color.Transparent;
            lb_Language.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Language.ForeColor = Color.Yellow;
            lb_Language.Location = new Point(83, 181);
            lb_Language.Margin = new Padding(5, 0, 5, 0);
            lb_Language.Name = "lb_Language";
            lb_Language.Size = new Size(182, 50);
            lb_Language.TabIndex = 3;
            lb_Language.Text = "Language";
            // 
            // lb_Debug
            // 
            lb_Debug.AutoSize = true;
            lb_Debug.BackColor = Color.Transparent;
            lb_Debug.ForeColor = Color.Yellow;
            lb_Debug.Location = new Point(1414, 14);
            lb_Debug.Margin = new Padding(5, 0, 5, 0);
            lb_Debug.Name = "lb_Debug";
            lb_Debug.Size = new Size(78, 32);
            lb_Debug.TabIndex = 4;
            lb_Debug.Text = "label1";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.BackColor = Color.Transparent;
            lb_Info.ForeColor = Color.Yellow;
            lb_Info.Location = new Point(20, 961);
            lb_Info.Margin = new Padding(5, 0, 5, 0);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(524, 32);
            lb_Info.TabIndex = 5;
            lb_Info.Text = "Changes take effect after you leave the settings";
            // 
            // lb_Dev
            // 
            lb_Dev.AutoSize = true;
            lb_Dev.BackColor = Color.Transparent;
            lb_Dev.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Dev.ForeColor = Color.Yellow;
            lb_Dev.Location = new Point(83, 321);
            lb_Dev.Margin = new Padding(5, 0, 5, 0);
            lb_Dev.Name = "lb_Dev";
            lb_Dev.Size = new Size(330, 50);
            lb_Dev.TabIndex = 6;
            lb_Dev.Text = "Developer Options";
            // 
            // chbDev
            // 
            chbDev.AutoSize = true;
            chbDev.BackColor = Color.Transparent;
            chbDev.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            chbDev.ForeColor = Color.Yellow;
            chbDev.Location = new Point(83, 398);
            chbDev.Name = "chbDev";
            chbDev.Size = new Size(215, 44);
            chbDev.TabIndex = 7;
            chbDev.Text = "Debug Menu";
            chbDev.UseVisualStyleBackColor = false;
            chbDev.CheckedChanged += chbDev_CheckedChanged;
            // 
            // btn_ResetBest
            // 
            btn_ResetBest.BackColor = Color.Yellow;
            btn_ResetBest.Location = new Point(83, 448);
            btn_ResetBest.Name = "btn_ResetBest";
            btn_ResetBest.Size = new Size(233, 46);
            btn_ResetBest.TabIndex = 8;
            btn_ResetBest.Text = "Reset Best Score";
            btn_ResetBest.UseVisualStyleBackColor = false;
            btn_ResetBest.Click += btn_ResetBest_Click;
            // 
            // Settings
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Runway_BG;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1548, 1002);
            Controls.Add(btn_ResetBest);
            Controls.Add(chbDev);
            Controls.Add(lb_Dev);
            Controls.Add(lb_Info);
            Controls.Add(lb_Debug);
            Controls.Add(lb_Language);
            Controls.Add(cmb_Language);
            Controls.Add(btn_Back);
            Controls.Add(lb_Settings);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPŠ-Kart | Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Settings;
        private Button btn_Back;
        private ComboBox cmb_Language;
        private Label lb_Language;
        private Label lb_Debug;
        private Label lb_Info;
        private Label lb_Dev;
        private CheckBox chbDev;
        private Button btn_ResetBest;
    }
}