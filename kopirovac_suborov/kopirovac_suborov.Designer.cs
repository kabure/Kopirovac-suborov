namespace kopirovac_suborov
{
    partial class OknoMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoMain));
            this.btnCestaZdroj = new System.Windows.Forms.Button();
            this.lblZdrojovyPriecinok = new System.Windows.Forms.Label();
            this.tbZdroj = new System.Windows.Forms.TextBox();
            this.tbCiel = new System.Windows.Forms.TextBox();
            this.lblCielovyPriecinok = new System.Windows.Forms.Label();
            this.btnCestaCiel = new System.Windows.Forms.Button();
            this.tbUspesne = new System.Windows.Forms.TextBox();
            this.tbChyba = new System.Windows.Forms.TextBox();
            this.lblUspesne = new System.Windows.Forms.Label();
            this.lblChyba = new System.Windows.Forms.Label();
            this.tbZoznam = new System.Windows.Forms.TextBox();
            this.btnKopirovat = new System.Windows.Forms.Button();
            this.lblZoznamSuborov = new System.Windows.Forms.Label();
            this.lblPocetZadanych = new System.Windows.Forms.Label();
            this.lblPocitadloOk = new System.Windows.Forms.Label();
            this.lblPocitadloError = new System.Windows.Forms.Label();
            this.btnNewFind = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCestaZdroj
            // 
            this.btnCestaZdroj.Location = new System.Drawing.Point(518, 39);
            this.btnCestaZdroj.Name = "btnCestaZdroj";
            this.btnCestaZdroj.Size = new System.Drawing.Size(109, 23);
            this.btnCestaZdroj.TabIndex = 0;
            this.btnCestaZdroj.Text = "Browse";
            this.btnCestaZdroj.UseVisualStyleBackColor = true;
            this.btnCestaZdroj.Click += new System.EventHandler(this.btnCestaZdroj_Click);
            // 
            // lblZdrojovyPriecinok
            // 
            this.lblZdrojovyPriecinok.AutoSize = true;
            this.lblZdrojovyPriecinok.Location = new System.Drawing.Point(12, 39);
            this.lblZdrojovyPriecinok.Name = "lblZdrojovyPriecinok";
            this.lblZdrojovyPriecinok.Size = new System.Drawing.Size(94, 13);
            this.lblZdrojovyPriecinok.TabIndex = 1;
            this.lblZdrojovyPriecinok.Text = "Zdrojový priečinok";
            // 
            // tbZdroj
            // 
            this.tbZdroj.Location = new System.Drawing.Point(113, 39);
            this.tbZdroj.Name = "tbZdroj";
            this.tbZdroj.Size = new System.Drawing.Size(390, 20);
            this.tbZdroj.TabIndex = 2;
            // 
            // tbCiel
            // 
            this.tbCiel.Location = new System.Drawing.Point(113, 70);
            this.tbCiel.Name = "tbCiel";
            this.tbCiel.Size = new System.Drawing.Size(390, 20);
            this.tbCiel.TabIndex = 3;
            // 
            // lblCielovyPriecinok
            // 
            this.lblCielovyPriecinok.AutoSize = true;
            this.lblCielovyPriecinok.Location = new System.Drawing.Point(12, 70);
            this.lblCielovyPriecinok.Name = "lblCielovyPriecinok";
            this.lblCielovyPriecinok.Size = new System.Drawing.Size(89, 13);
            this.lblCielovyPriecinok.TabIndex = 4;
            this.lblCielovyPriecinok.Text = "Cieľový priečinok";
            // 
            // btnCestaCiel
            // 
            this.btnCestaCiel.Location = new System.Drawing.Point(518, 67);
            this.btnCestaCiel.Name = "btnCestaCiel";
            this.btnCestaCiel.Size = new System.Drawing.Size(109, 23);
            this.btnCestaCiel.TabIndex = 5;
            this.btnCestaCiel.Text = "Browse";
            this.btnCestaCiel.UseVisualStyleBackColor = true;
            this.btnCestaCiel.Click += new System.EventHandler(this.btnCestaCiel_Click);
            // 
            // tbUspesne
            // 
            this.tbUspesne.Location = new System.Drawing.Point(317, 177);
            this.tbUspesne.Multiline = true;
            this.tbUspesne.Name = "tbUspesne";
            this.tbUspesne.Size = new System.Drawing.Size(290, 259);
            this.tbUspesne.TabIndex = 6;
            this.tbUspesne.Visible = false;
            // 
            // tbChyba
            // 
            this.tbChyba.Location = new System.Drawing.Point(629, 177);
            this.tbChyba.Multiline = true;
            this.tbChyba.Name = "tbChyba";
            this.tbChyba.Size = new System.Drawing.Size(290, 259);
            this.tbChyba.TabIndex = 7;
            this.tbChyba.Visible = false;
            // 
            // lblUspesne
            // 
            this.lblUspesne.AutoSize = true;
            this.lblUspesne.Location = new System.Drawing.Point(314, 151);
            this.lblUspesne.Name = "lblUspesne";
            this.lblUspesne.Size = new System.Drawing.Size(112, 13);
            this.lblUspesne.TabIndex = 8;
            this.lblUspesne.Text = "Úspešne skopírované";
            this.lblUspesne.Visible = false;
            // 
            // lblChyba
            // 
            this.lblChyba.AutoSize = true;
            this.lblChyba.Location = new System.Drawing.Point(626, 151);
            this.lblChyba.Name = "lblChyba";
            this.lblChyba.Size = new System.Drawing.Size(107, 13);
            this.lblChyba.TabIndex = 9;
            this.lblChyba.Text = "Chyba pri kopírovaní";
            this.lblChyba.Visible = false;
            // 
            // tbZoznam
            // 
            this.tbZoznam.Location = new System.Drawing.Point(15, 177);
            this.tbZoznam.Multiline = true;
            this.tbZoznam.Name = "tbZoznam";
            this.tbZoznam.Size = new System.Drawing.Size(290, 259);
            this.tbZoznam.TabIndex = 10;
            // 
            // btnKopirovat
            // 
            this.btnKopirovat.Location = new System.Drawing.Point(16, 464);
            this.btnKopirovat.Name = "btnKopirovat";
            this.btnKopirovat.Size = new System.Drawing.Size(109, 23);
            this.btnKopirovat.TabIndex = 12;
            this.btnKopirovat.Text = "Kopírovať ";
            this.btnKopirovat.UseVisualStyleBackColor = true;
            this.btnKopirovat.Click += new System.EventHandler(this.btnKopirovat_Click);
            // 
            // lblZoznamSuborov
            // 
            this.lblZoznamSuborov.AutoSize = true;
            this.lblZoznamSuborov.Location = new System.Drawing.Point(16, 151);
            this.lblZoznamSuborov.Name = "lblZoznamSuborov";
            this.lblZoznamSuborov.Size = new System.Drawing.Size(86, 13);
            this.lblZoznamSuborov.TabIndex = 13;
            this.lblZoznamSuborov.Text = "Zoznam súborov";
            this.lblZoznamSuborov.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPocetZadanych
            // 
            this.lblPocetZadanych.AutoSize = true;
            this.lblPocetZadanych.Location = new System.Drawing.Point(110, 151);
            this.lblPocetZadanych.Name = "lblPocetZadanych";
            this.lblPocetZadanych.Size = new System.Drawing.Size(50, 13);
            this.lblPocetZadanych.TabIndex = 14;
            this.lblPocetZadanych.Text = "pocitadlo";
            this.lblPocetZadanych.Visible = false;
            // 
            // lblPocitadloOk
            // 
            this.lblPocitadloOk.AutoSize = true;
            this.lblPocitadloOk.Location = new System.Drawing.Point(444, 151);
            this.lblPocitadloOk.Name = "lblPocitadloOk";
            this.lblPocitadloOk.Size = new System.Drawing.Size(50, 13);
            this.lblPocitadloOk.TabIndex = 15;
            this.lblPocitadloOk.Text = "pocitadlo";
            this.lblPocitadloOk.Visible = false;
            // 
            // lblPocitadloError
            // 
            this.lblPocitadloError.AutoSize = true;
            this.lblPocitadloError.Location = new System.Drawing.Point(758, 151);
            this.lblPocitadloError.Name = "lblPocitadloError";
            this.lblPocitadloError.Size = new System.Drawing.Size(50, 13);
            this.lblPocitadloError.TabIndex = 16;
            this.lblPocitadloError.Text = "pocitadlo";
            this.lblPocitadloError.Visible = false;
            // 
            // btnNewFind
            // 
            this.btnNewFind.Location = new System.Drawing.Point(213, 464);
            this.btnNewFind.Name = "btnNewFind";
            this.btnNewFind.Size = new System.Drawing.Size(109, 23);
            this.btnNewFind.TabIndex = 17;
            this.btnNewFind.Text = "Nové hľadanie";
            this.btnNewFind.UseVisualStyleBackColor = true;
            this.btnNewFind.Click += new System.EventHandler(this.btnNewFind_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(971, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(63, 17);
            this.statusLbl.Text = "Pripravený";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgrameToolStripMenuItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(24, 20);
            this.menuItem.Text = "?";
            // 
            // oProgrameToolStripMenuItem
            // 
            this.oProgrameToolStripMenuItem.Name = "oProgrameToolStripMenuItem";
            this.oProgrameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgrameToolStripMenuItem.Text = "O programe";
            this.oProgrameToolStripMenuItem.Click += new System.EventHandler(this.oProgrameToolStripMenuItem_Click);
            // 
            // OknoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNewFind);
            this.Controls.Add(this.lblPocitadloError);
            this.Controls.Add(this.lblPocitadloOk);
            this.Controls.Add(this.lblPocetZadanych);
            this.Controls.Add(this.lblZoznamSuborov);
            this.Controls.Add(this.btnKopirovat);
            this.Controls.Add(this.tbZoznam);
            this.Controls.Add(this.lblChyba);
            this.Controls.Add(this.lblUspesne);
            this.Controls.Add(this.tbChyba);
            this.Controls.Add(this.tbUspesne);
            this.Controls.Add(this.btnCestaCiel);
            this.Controls.Add(this.lblCielovyPriecinok);
            this.Controls.Add(this.tbCiel);
            this.Controls.Add(this.tbZdroj);
            this.Controls.Add(this.lblZdrojovyPriecinok);
            this.Controls.Add(this.btnCestaZdroj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoMain";
            this.Text = "Kopírovač súborov";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCestaZdroj;
        private System.Windows.Forms.Label lblZdrojovyPriecinok;
        private System.Windows.Forms.TextBox tbZdroj;
        private System.Windows.Forms.TextBox tbCiel;
        private System.Windows.Forms.Label lblCielovyPriecinok;
        private System.Windows.Forms.Button btnCestaCiel;
        private System.Windows.Forms.TextBox tbUspesne;
        private System.Windows.Forms.TextBox tbChyba;
        private System.Windows.Forms.Label lblUspesne;
        private System.Windows.Forms.Label lblChyba;
        private System.Windows.Forms.TextBox tbZoznam;
        private System.Windows.Forms.Button btnKopirovat;
        private System.Windows.Forms.Label lblZoznamSuborov;
        private System.Windows.Forms.Label lblPocetZadanych;
        private System.Windows.Forms.Label lblPocitadloOk;
        private System.Windows.Forms.Label lblPocitadloError;
        private System.Windows.Forms.Button btnNewFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgrameToolStripMenuItem;
    }
}

