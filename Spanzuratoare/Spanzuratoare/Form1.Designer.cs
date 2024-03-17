namespace Spanzuratoarea
{
    partial class FormSpanzuratoarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSetari = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNrIncercari = new System.Windows.Forms.TextBox();
            this.SaveSetari = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelNrIncercari = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonJoaca = new System.Windows.Forms.Button();
            this.panelJoc = new System.Windows.Forms.Panel();
            this.labelAfisareLitereFolosite = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelLitera = new System.Windows.Forms.Label();
            this.textBoxLitera = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelSetari.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelJoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Purple;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.setariToolStripMenuItem,
            this.jocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1510, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // setariToolStripMenuItem
            // 
            this.setariToolStripMenuItem.Name = "setariToolStripMenuItem";
            this.setariToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.setariToolStripMenuItem.Text = "Setari";
            this.setariToolStripMenuItem.Click += new System.EventHandler(this.setariToolStripMenuItem_Click);
            // 
            // jocToolStripMenuItem
            // 
            this.jocToolStripMenuItem.Name = "jocToolStripMenuItem";
            this.jocToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.jocToolStripMenuItem.Text = "Joc";
            this.jocToolStripMenuItem.Click += new System.EventHandler(this.jocToolStripMenuItem_Click);
            // 
            // panelSetari
            // 
            this.panelSetari.BackColor = System.Drawing.Color.Green;
            this.panelSetari.Controls.Add(this.label3);
            this.panelSetari.Controls.Add(this.textBoxNrIncercari);
            this.panelSetari.Controls.Add(this.SaveSetari);
            this.panelSetari.Controls.Add(this.labelNume);
            this.panelSetari.Controls.Add(this.labelNrIncercari);
            this.panelSetari.Controls.Add(this.textBoxNume);
            this.panelSetari.Location = new System.Drawing.Point(1065, 31);
            this.panelSetari.Name = "panelSetari";
            this.panelSetari.Size = new System.Drawing.Size(567, 373);
            this.panelSetari.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(207, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setari";
            // 
            // textBoxNrIncercari
            // 
            this.textBoxNrIncercari.Location = new System.Drawing.Point(268, 155);
            this.textBoxNrIncercari.MaxLength = 1;
            this.textBoxNrIncercari.Name = "textBoxNrIncercari";
            this.textBoxNrIncercari.Size = new System.Drawing.Size(100, 22);
            this.textBoxNrIncercari.TabIndex = 4;
            this.textBoxNrIncercari.TextChanged += new System.EventHandler(this.textBoxNrIncercari_TextChanged);
            // 
            // SaveSetari
            // 
            this.SaveSetari.Location = new System.Drawing.Point(363, 264);
            this.SaveSetari.Name = "SaveSetari";
            this.SaveSetari.Size = new System.Drawing.Size(103, 66);
            this.SaveSetari.TabIndex = 3;
            this.SaveSetari.Text = "Save";
            this.SaveSetari.UseVisualStyleBackColor = true;
            this.SaveSetari.Click += new System.EventHandler(this.SaveSetari_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Aqua;
            this.labelNume.Location = new System.Drawing.Point(125, 111);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(56, 17);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Numele";
            // 
            // labelNrIncercari
            // 
            this.labelNrIncercari.AutoSize = true;
            this.labelNrIncercari.BackColor = System.Drawing.Color.Aqua;
            this.labelNrIncercari.Location = new System.Drawing.Point(125, 160);
            this.labelNrIncercari.Name = "labelNrIncercari";
            this.labelNrIncercari.Size = new System.Drawing.Size(128, 17);
            this.labelNrIncercari.TabIndex = 2;
            this.labelNrIncercari.Text = "Numar de incercari";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(268, 108);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Maroon;
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.buttonJoaca);
            this.panelHome.Location = new System.Drawing.Point(1065, 410);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(413, 478);
            this.panelHome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spanzuratoare";
            // 
            // buttonJoaca
            // 
            this.buttonJoaca.Location = new System.Drawing.Point(129, 302);
            this.buttonJoaca.Name = "buttonJoaca";
            this.buttonJoaca.Size = new System.Drawing.Size(143, 98);
            this.buttonJoaca.TabIndex = 0;
            this.buttonJoaca.Text = "Joaca";
            this.buttonJoaca.UseVisualStyleBackColor = true;
            this.buttonJoaca.Click += new System.EventHandler(this.buttonJoaca_Click);
            // 
            // panelJoc
            // 
            this.panelJoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelJoc.Controls.Add(this.labelAfisareLitereFolosite);
            this.panelJoc.Controls.Add(this.flowLayoutPanel1);
            this.panelJoc.Controls.Add(this.buttonRestart);
            this.panelJoc.Controls.Add(this.labelLitera);
            this.panelJoc.Controls.Add(this.textBoxLitera);
            this.panelJoc.Controls.Add(this.pictureBox1);
            this.panelJoc.Location = new System.Drawing.Point(0, 52);
            this.panelJoc.Name = "panelJoc";
            this.panelJoc.Size = new System.Drawing.Size(1046, 616);
            this.panelJoc.TabIndex = 4;
            // 
            // labelAfisareLitereFolosite
            // 
            this.labelAfisareLitereFolosite.AutoSize = true;
            this.labelAfisareLitereFolosite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfisareLitereFolosite.Location = new System.Drawing.Point(423, 493);
            this.labelAfisareLitereFolosite.Name = "labelAfisareLitereFolosite";
            this.labelAfisareLitereFolosite.Size = new System.Drawing.Size(144, 25);
            this.labelAfisareLitereFolosite.TabIndex = 5;
            this.labelAfisareLitereFolosite.Text = "Litere Folosite: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(428, 341);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 93);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(776, 134);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(102, 71);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelLitera
            // 
            this.labelLitera.AutoSize = true;
            this.labelLitera.Location = new System.Drawing.Point(509, 161);
            this.labelLitera.Name = "labelLitera";
            this.labelLitera.Size = new System.Drawing.Size(44, 17);
            this.labelLitera.TabIndex = 2;
            this.labelLitera.Text = "Litera";
            // 
            // textBoxLitera
            // 
            this.textBoxLitera.Location = new System.Drawing.Point(596, 158);
            this.textBoxLitera.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBoxLitera.MaxLength = 37486;
            this.textBoxLitera.Name = "textBoxLitera";
            this.textBoxLitera.Size = new System.Drawing.Size(105, 22);
            this.textBoxLitera.TabIndex = 1;
            this.textBoxLitera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLitera_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 547);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormSpanzuratoarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1510, 857);
            this.Controls.Add(this.panelJoc);
            this.Controls.Add(this.panelSetari);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSpanzuratoarea";
            this.Text = "Spanzuratoarea";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSetari.ResumeLayout(false);
            this.panelSetari.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelJoc.ResumeLayout(false);
            this.panelJoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jocToolStripMenuItem;
        private System.Windows.Forms.Panel panelSetari;
        private System.Windows.Forms.Button SaveSetari;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelNrIncercari;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonJoaca;
        private System.Windows.Forms.Panel panelJoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLitera;
        private System.Windows.Forms.TextBox textBoxLitera;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelAfisareLitereFolosite;
        private System.Windows.Forms.TextBox textBoxNrIncercari;
        private System.Windows.Forms.Label label3;
    }
}

