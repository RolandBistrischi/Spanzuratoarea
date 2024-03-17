using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public partial class FormSpanzuratoarea : Form
    {
        private int litereInvizibile = 0;
        private string cuvant = "Pink ".ToUpper();
        private List<Label> listadeLabeluri = new List<Label>();
        private string listadelitereProaste;
        private int nrIncercari = 5;
        private string nume = "Jucatorule";

        public FormSpanzuratoarea()
        {
            InitializeComponent();
            panelSetari.Visible = false;
            panelHome.Visible = true;
            panelJoc.Visible = false;
            AsezarePanelHome();
        }

        private void buttonJoaca_Click( object sender, EventArgs e )
        {
            panelHome.Visible = false;
            panelSetari.Visible = false;
            panelJoc.Visible = true;
            Restart();
        }
        private void buttonRestart_Click( object sender, EventArgs e )
        {
            Restart();
        }
        private void textBoxNrIncercari_TextChanged( object sender, EventArgs e )
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNrIncercari.Text, "[^0-9]"))
                textBoxNrIncercari.Text = textBoxNrIncercari.Text.Remove(textBoxNrIncercari.Text.Length - 1);
        }
        private void SaveSetari_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(textBoxNrIncercari.Text))
                return;
            nrIncercari = Convert.ToInt32(textBoxNrIncercari.Text);
            nume = textBoxNume.Text;
        }
        private void homeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            panelHome.Visible = true;
            panelJoc.Visible = false;
            panelSetari.Visible = false;
            AsezarePanelHome();
        }
        private void setariToolStripMenuItem_Click( object sender, EventArgs e )
        {
            panelHome.Visible = false;
            panelJoc.Visible = false;
            panelSetari.Visible = true;
            AsezarePanelSetari();
        }
        private void jocToolStripMenuItem_Click( object sender, EventArgs e )
        {
            panelHome.Visible = false;
            panelJoc.Visible = true;
            panelSetari.Visible = false;
            Restart();
        }

        private void textBoxLitera_KeyDown( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Enter)
                return;
            e.SuppressKeyPress = true;
            VerificaLitera();
        }

        private void VerificaLitera()
        {
            string a = textBoxLitera.Text.ToUpper().Trim();
            if (string.IsNullOrEmpty(a))
                return;
            if (litereInvizibile == 0)
            {
                textBoxLitera.Clear();
                MessageBox.Show("Bravo," + nume + "! Ai castigat!");
                Restart();
                return;
            }

            int b = litereInvizibile;
            bool ok = false;
            for (int i = 0; i < cuvant.Length; i++)
            {
                if (cuvant [i] == a [0])
                {
                    ok = true;
                    string v = listadeLabeluri [i].Text, bsdd = Convert.ToString(a);
                    if (listadeLabeluri [i].Text != Convert.ToString(a))
                    {
                        litereInvizibile--;
                        listadeLabeluri [i].Text = Convert.ToString(a);
                    }
                }
            }
            if (litereInvizibile == 0)
            {
                textBoxLitera.Clear();
                MessageBox.Show("Bravo," + nume + "! Ai castigat!");
                Restart();
                return;
            }
            if (b == litereInvizibile && !listadelitereProaste.Contains(a) && !ok)
            {
                labelAfisareLitereFolosite.Text = labelAfisareLitereFolosite.Text + a [0] + ' ';
                listadelitereProaste = listadelitereProaste + a [0];

                AfisaredeImagini(listadelitereProaste.Length);
                if (listadelitereProaste.Length >= nrIncercari)
                {
                    MessageBox.Show("Din pacate, " + nume + " ai pierdut. Cuvantul era " + cuvant + "!");
                    Restart();
                }
            }
            textBoxLitera.Clear();
        }

        private void AfisaredeImagini( int lungime )
        {
            if (lungime == nrIncercari)
            {
                pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare5.png");
                return;
            }
            try
            {
                switch (lungime)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare1.png");
                        return;
                    case 2:
                        pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare2.png");
                        return;
                    case 3:
                        pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare3.png");
                        return;
                    case 4:
                        pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare4.png");
                        return;
                    default:
                        return;
                }
            }
            catch { MessageBox.Show("Eroare la gasirea imaginilor."); return; }
        }
        private void Restart()
        {
            AsezarePanelJoc();
            textBoxLitera.MaxLength = 1;
            litereInvizibile = 0;
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\partitia d\Visual Studio\Informatica Industriala\teme\tema1\tema1\Resources\Spanzuratoare.png"); // Încarcă imaginea din fișier
            }
            catch { MessageBox.Show("Eroare la citirea din fisier a imaginii."); return; }

            List<string> vector = new List<string>();
            flowLayoutPanel1.Controls.Clear();
            listadeLabeluri.Clear();
            listadelitereProaste = "";
            textBoxLitera.Clear();
            labelAfisareLitereFolosite.Text = "Litere Folosite: ";

            cuvant = "";
            using (StreamReader streamreader = new StreamReader("Cuvinte.txt"))
            {
                while (!streamreader.EndOfStream)
                {
                    string line = streamreader.ReadLine();
                    string [] temp = line.Split('|');
                    vector.AddRange(temp);
                }
            }
            string [] toateCuvintele = vector.ToArray();
            Random rnd = new Random();
            int index = rnd.Next(0, toateCuvintele.Length);

            cuvant = toateCuvintele [index].Trim().ToUpper();
            string cuvantCenzurat = Regex.Replace(cuvant, "[A-Za-zăâîșțĂÂÎȘȚ]", "_");

            foreach (char litera in cuvantCenzurat)
            {
                if (litera == '_')
                    litereInvizibile++;
                Label label = new Label
                {
                    Text = litera.ToString().ToUpper(),
                    AutoSize = true,
                    Margin = new Padding(5)
                };

                flowLayoutPanel1.Controls.Add(label);
                listadeLabeluri.Add(label);
            }
            LiteraRandom();
        }

        private void AsezarePanelJoc()
        {
            panelJoc.Location = new Point(0, menuStrip1.Height);
            ClientSize = new Size(panelJoc.Width, panelJoc.Height + menuStrip1.Height);
        }
        private void AsezarePanelHome()
        {
            panelHome.Location = new Point(0, menuStrip1.Height);
            ClientSize = new Size(panelHome.Width, panelHome.Height + menuStrip1.Height);
        }
        private void AsezarePanelSetari()
        {
            panelSetari.Location = new Point(0, menuStrip1.Height);
            ClientSize = new Size(panelSetari.Width, panelSetari.Height + menuStrip1.Height);
        }



        private void LiteraRandom()
        {
            int nrLitereAratate = 0, initial = litereInvizibile;

            if (cuvant.Length <= 4)
                nrLitereAratate = 1;
            else
            {
                if (cuvant.Length > 4 && cuvant.Length <= 6)
                    nrLitereAratate = 2;
                else
                    nrLitereAratate = 4;

            }


            while (litereInvizibile + nrLitereAratate > initial)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, cuvant.Length);
                textBoxLitera.Text = Convert.ToString(cuvant [index]);
                VerificaLitera();
            }
            int a = 0;
        }
    }
}
