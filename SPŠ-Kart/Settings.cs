   using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPŠ_Kart
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        string[] arrayLang = { "English", "Čeština" };

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Main = new Form1();
            Main.ShowDialog();
            this.Close();
        }

        int BestScore;
        int DevEnabled;
        int SetLang;
        string ResetedText;

        private void Settings_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.Runway_BG;
            cmb_Language.Items.Clear();
            cmb_Language.Items.AddRange(arrayLang);
            using (StreamReader sr = new StreamReader("Settings.json"))
            {
                int.TryParse(sr.ReadLine(), out SetLang);
                int.TryParse(sr.ReadLine(), out BestScore);
                int.TryParse(sr.ReadLine(), out DevEnabled);

            }
            if (SetLang == 1)
            {
                lb_Debug.Text = "EN";
                cmb_Language.SelectedIndex = 0;
                ResetedText = "Your best score was reseted";
                
            }
            if (SetLang == 2)
            {
                lb_Debug.Text = "CZ";
                btn_Back.Text = "Zpět";
                lb_Settings.Text = "Nastavení";
                lb_Language.Text = "Jazyk";
                lb_Info.Text = "Změny se projeví po opuštění nastavení";
                Text = "SPŠ-Kart | Nastavení";
                lb_Dev.Text = "Vývojářská nastavení";
                chbDev.Text = "Pomocné Informační menu";
                btn_ResetBest.Text = "Zresetovat nejlepší skóre";
                ResetedText = "Vaše nejlepší skóre bylo zresetováno";
                cmb_Language.SelectedIndex = 1;
            }
            else { }

            if (DevEnabled == 0)
            {
                lb_Debug.Visible = false;
                chbDev.Checked = false;

            }
            if (DevEnabled == 1)
            {
                chbDev.Checked = true;
            }
            else { }



        }

        private void cmb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Settings.json"))
            {
                if (cmb_Language.SelectedIndex == 0)
                {
                    sw.WriteLine("1");
                }
                else
                {
                    sw.WriteLine("2");
                }
                sw.WriteLine(BestScore);
                sw.WriteLine(DevEnabled);
            }


        }

        private void chbDev_CheckedChanged(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Settings.json"))
            {
                sw.WriteLine(SetLang);
                sw.WriteLine(BestScore);
                if (chbDev.Checked) sw.WriteLine("1");
                else { sw.WriteLine("0"); }
            }

        }

        private void btn_ResetBest_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Settings.json"))
            {
                sw.WriteLine(SetLang);
                sw.WriteLine("0");
                sw.WriteLine(DevEnabled);
            }
            MessageBox.Show(ResetedText);
        }
    }
}
