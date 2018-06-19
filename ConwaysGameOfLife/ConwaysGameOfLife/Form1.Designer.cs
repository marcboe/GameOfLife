namespace ConwaysGameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLeeren = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.buttonEinzelschritt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbenEinstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zellfFarbetotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiwelt = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(260, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 580);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(24, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeeren
            // 
            this.buttonLeeren.Location = new System.Drawing.Point(24, 74);
            this.buttonLeeren.Name = "buttonLeeren";
            this.buttonLeeren.Size = new System.Drawing.Size(75, 23);
            this.buttonLeeren.TabIndex = 2;
            this.buttonLeeren.Text = "Leeren";
            this.buttonLeeren.UseVisualStyleBackColor = true;
            this.buttonLeeren.Click += new System.EventHandler(this.buttonLeeren_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(12, 542);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(212, 45);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(25, 518);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(185, 13);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Simulationsgeschwindigkeit anpassen";
            // 
            // buttonEinzelschritt
            // 
            this.buttonEinzelschritt.Location = new System.Drawing.Point(149, 31);
            this.buttonEinzelschritt.Name = "buttonEinzelschritt";
            this.buttonEinzelschritt.Size = new System.Drawing.Size(75, 23);
            this.buttonEinzelschritt.TabIndex = 5;
            this.buttonEinzelschritt.Text = "Einzelschritt";
            this.buttonEinzelschritt.UseVisualStyleBackColor = true;
            this.buttonEinzelschritt.Click += new System.EventHandler(this.buttonEinzelschritt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farbenEinstellenToolStripMenuItem,
            this.zellfFarbetotToolStripMenuItem,
            this.spielfeldSpeichernToolStripMenuItem,
            this.spielfeldLadenToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // farbenEinstellenToolStripMenuItem
            // 
            this.farbenEinstellenToolStripMenuItem.Name = "farbenEinstellenToolStripMenuItem";
            this.farbenEinstellenToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.farbenEinstellenToolStripMenuItem.Text = "Zell-Farbe wählen (lebend)";
            this.farbenEinstellenToolStripMenuItem.Click += new System.EventHandler(this.farbenEinstellenToolStripMenuItem_Click);
            // 
            // zellfFarbetotToolStripMenuItem
            // 
            this.zellfFarbetotToolStripMenuItem.Name = "zellfFarbetotToolStripMenuItem";
            this.zellfFarbetotToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.zellfFarbetotToolStripMenuItem.Text = "Zell-Farbe wählen (tot)";
            this.zellfFarbetotToolStripMenuItem.Click += new System.EventHandler(this.zellfFarbetotToolStripMenuItem_Click);
            // 
            // spielfeldSpeichernToolStripMenuItem
            // 
            this.spielfeldSpeichernToolStripMenuItem.Name = "spielfeldSpeichernToolStripMenuItem";
            this.spielfeldSpeichernToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.spielfeldSpeichernToolStripMenuItem.Text = "Spielfeld speichern";
            this.spielfeldSpeichernToolStripMenuItem.Click += new System.EventHandler(this.spielfeldSpeichernToolStripMenuItem_Click);
            // 
            // spielfeldLadenToolStripMenuItem
            // 
            this.spielfeldLadenToolStripMenuItem.Name = "spielfeldLadenToolStripMenuItem";
            this.spielfeldLadenToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.spielfeldLadenToolStripMenuItem.Text = "Spielfeld laden";
            this.spielfeldLadenToolStripMenuItem.Click += new System.EventHandler(this.spielfeldLadenToolStripMenuItem_Click);
            // antiwelt
            // 
            this.antiwelt.Location = new System.Drawing.Point(12, 435);
            this.antiwelt.Name = "antiwelt";
            this.antiwelt.Size = new System.Drawing.Size(75, 23);
            this.antiwelt.TabIndex = 7;
            this.antiwelt.Text = "Antiwelt";
            this.antiwelt.UseVisualStyleBackColor = true;
            this.antiwelt.Click += new System.EventHandler(this.antiwelt_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "0 Nachbarn",
            "1 Nachbarn",
            "2 Nachbarn",
            "3 Nachbarn",
            "4 Nachbarn",
            "5 Nachbarn",
            "6 Nachbarn",
            "7 Nachbarn",
            "8 Nachbarn"});
            this.checkedListBox1.Location = new System.Drawing.Point(134, 178);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 8;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "0 Nachbarn",
            "1 Nachbarn",
            "2 Nachbarn",
            "3 Nachbarn",
            "4 Nachbarn",
            "5 Nachbarn",
            "6 Nachbarn",
            "7 Nachbarn",
            "8 Nachbarn"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 178);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Belebe Zelle bei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Töte Zelle bei:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.antiwelt);
            this.Controls.Add(this.buttonEinzelschritt);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.buttonLeeren);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Marc und Peters GameOfLife - In die Zeichenfläche klicken, um zu starten.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLeeren;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button buttonEinzelschritt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbenEinstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zellfFarbetotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldLadenToolStripMenuItem;
        private System.Windows.Forms.Button antiwelt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

