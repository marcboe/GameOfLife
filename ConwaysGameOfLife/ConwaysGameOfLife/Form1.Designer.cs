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
            this.changeSet = new System.Windows.Forms.Button();
            this.resetChange = new System.Windows.Forms.Button();
            this.clearBox = new System.Windows.Forms.Button();
            this.tuemmler = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startscreen = new System.Windows.Forms.RadioButton();
            this.hallo = new System.Windows.Forms.RadioButton();
            this.pulsator = new System.Windows.Forms.RadioButton();
            this.oktagon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(390, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1199, 891);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 48);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeeren
            // 
            this.buttonLeeren.Location = new System.Drawing.Point(261, 48);
            this.buttonLeeren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeeren.Name = "buttonLeeren";
            this.buttonLeeren.Size = new System.Drawing.Size(112, 35);
            this.buttonLeeren.TabIndex = 2;
            this.buttonLeeren.Text = "Leeren";
            this.buttonLeeren.UseVisualStyleBackColor = true;
            this.buttonLeeren.Click += new System.EventHandler(this.buttonLeeren_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(18, 834);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(318, 69);
            this.trackBarSpeed.TabIndex = 3;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(38, 797);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(277, 20);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Simulationsgeschwindigkeit anpassen";
            // 
            // buttonEinzelschritt
            // 
            this.buttonEinzelschritt.Location = new System.Drawing.Point(140, 48);
            this.buttonEinzelschritt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEinzelschritt.Name = "buttonEinzelschritt";
            this.buttonEinzelschritt.Size = new System.Drawing.Size(112, 35);
            this.buttonEinzelschritt.TabIndex = 5;
            this.buttonEinzelschritt.Text = "Einzelschritt";
            this.buttonEinzelschritt.UseVisualStyleBackColor = true;
            this.buttonEinzelschritt.Click += new System.EventHandler(this.buttonEinzelschritt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 35);
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
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // farbenEinstellenToolStripMenuItem
            // 
            this.farbenEinstellenToolStripMenuItem.Name = "farbenEinstellenToolStripMenuItem";
            this.farbenEinstellenToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.farbenEinstellenToolStripMenuItem.Text = "Zell-Farbe wählen (lebend)";
            this.farbenEinstellenToolStripMenuItem.Click += new System.EventHandler(this.farbenEinstellenToolStripMenuItem_Click);
            // 
            // zellfFarbetotToolStripMenuItem
            // 
            this.zellfFarbetotToolStripMenuItem.Name = "zellfFarbetotToolStripMenuItem";
            this.zellfFarbetotToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.zellfFarbetotToolStripMenuItem.Text = "Zell-Farbe wählen (tot)";
            this.zellfFarbetotToolStripMenuItem.Click += new System.EventHandler(this.zellfFarbetotToolStripMenuItem_Click);
            // 
            // spielfeldSpeichernToolStripMenuItem
            // 
            this.spielfeldSpeichernToolStripMenuItem.Name = "spielfeldSpeichernToolStripMenuItem";
            this.spielfeldSpeichernToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.spielfeldSpeichernToolStripMenuItem.Text = "Spielfeld speichern";
            this.spielfeldSpeichernToolStripMenuItem.Click += new System.EventHandler(this.spielfeldSpeichernToolStripMenuItem_Click);
            // 
            // spielfeldLadenToolStripMenuItem
            // 
            this.spielfeldLadenToolStripMenuItem.Name = "spielfeldLadenToolStripMenuItem";
            this.spielfeldLadenToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.spielfeldLadenToolStripMenuItem.Text = "Spielfeld laden";
            this.spielfeldLadenToolStripMenuItem.Click += new System.EventHandler(this.spielfeldLadenToolStripMenuItem_Click);
            // 
            // antiwelt
            // 
            this.antiwelt.Location = new System.Drawing.Point(36, 666);
            this.antiwelt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.antiwelt.Name = "antiwelt";
            this.antiwelt.Size = new System.Drawing.Size(112, 35);
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
            this.checkedListBox1.Location = new System.Drawing.Point(201, 274);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(178, 193);
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
            this.checkedListBox2.Location = new System.Drawing.Point(18, 274);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(178, 193);
            this.checkedListBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Belebe Zelle bei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Töte Zelle bei:";
            // 
            // changeSet
            // 
            this.changeSet.Location = new System.Drawing.Point(18, 505);
            this.changeSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeSet.Name = "changeSet";
            this.changeSet.Size = new System.Drawing.Size(112, 35);
            this.changeSet.TabIndex = 12;
            this.changeSet.Text = "Ändern";
            this.changeSet.UseVisualStyleBackColor = true;
            this.changeSet.Click += new System.EventHandler(this.changeSet_Click);
            // 
            // resetChange
            // 
            this.resetChange.Location = new System.Drawing.Point(261, 505);
            this.resetChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetChange.Name = "resetChange";
            this.resetChange.Size = new System.Drawing.Size(112, 35);
            this.resetChange.TabIndex = 13;
            this.resetChange.Text = "Standard";
            this.resetChange.UseVisualStyleBackColor = true;
            this.resetChange.Click += new System.EventHandler(this.resetChange_Click);
            // 
            // clearBox
            // 
            this.clearBox.Location = new System.Drawing.Point(140, 505);
            this.clearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(112, 35);
            this.clearBox.TabIndex = 14;
            this.clearBox.Text = "Leeren";
            this.clearBox.UseVisualStyleBackColor = true;
            this.clearBox.Click += new System.EventHandler(this.clearBox_Click);
            // 
            // tuemmler
            // 
            this.tuemmler.AutoSize = true;
            this.tuemmler.Location = new System.Drawing.Point(6, 12);
            this.tuemmler.Name = "tuemmler";
            this.tuemmler.Size = new System.Drawing.Size(95, 24);
            this.tuemmler.TabIndex = 15;
            this.tuemmler.TabStop = true;
            this.tuemmler.Text = "Tümmler";
            this.tuemmler.UseVisualStyleBackColor = true;
            this.tuemmler.Click += new System.EventHandler(this.tuemmler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startscreen);
            this.groupBox1.Controls.Add(this.hallo);
            this.groupBox1.Controls.Add(this.pulsator);
            this.groupBox1.Controls.Add(this.oktagon);
            this.groupBox1.Controls.Add(this.tuemmler);
            this.groupBox1.Location = new System.Drawing.Point(18, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 145);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // startscreen
            // 
            this.startscreen.AutoSize = true;
            this.startscreen.Location = new System.Drawing.Point(6, 102);
            this.startscreen.Name = "startscreen";
            this.startscreen.Size = new System.Drawing.Size(117, 24);
            this.startscreen.TabIndex = 19;
            this.startscreen.TabStop = true;
            this.startscreen.Text = "Startscreen";
            this.startscreen.UseVisualStyleBackColor = true;
            this.startscreen.Click += new System.EventHandler(this.startscreen_Click);
            // 
            // hallo
            // 
            this.hallo.AutoSize = true;
            this.hallo.Location = new System.Drawing.Point(160, 102);
            this.hallo.Name = "hallo";
            this.hallo.Size = new System.Drawing.Size(74, 24);
            this.hallo.TabIndex = 18;
            this.hallo.TabStop = true;
            this.hallo.Text = "Hallo!";
            this.hallo.UseVisualStyleBackColor = true;
            this.hallo.Click += new System.EventHandler(this.hallo_Click);
            // 
            // pulsator
            // 
            this.pulsator.AutoSize = true;
            this.pulsator.Location = new System.Drawing.Point(6, 72);
            this.pulsator.Name = "pulsator";
            this.pulsator.Size = new System.Drawing.Size(92, 24);
            this.pulsator.TabIndex = 17;
            this.pulsator.TabStop = true;
            this.pulsator.Text = "Pulsator";
            this.pulsator.UseVisualStyleBackColor = true;
            this.pulsator.Click += new System.EventHandler(this.pulsator_Click);
            // 
            // oktagon
            // 
            this.oktagon.AutoSize = true;
            this.oktagon.Location = new System.Drawing.Point(6, 42);
            this.oktagon.Name = "oktagon";
            this.oktagon.Size = new System.Drawing.Size(95, 24);
            this.oktagon.TabIndex = 16;
            this.oktagon.TabStop = true;
            this.oktagon.Text = "Oktagon";
            this.oktagon.UseVisualStyleBackColor = true;
            this.oktagon.Click += new System.EventHandler(this.oktagon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 922);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearBox);
            this.Controls.Add(this.resetChange);
            this.Controls.Add(this.changeSet);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Marc und Peters GameOfLife - In die Zeichenfläche klicken, um zu starten.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button changeSet;
        private System.Windows.Forms.Button resetChange;
        private System.Windows.Forms.Button clearBox;
        private System.Windows.Forms.RadioButton tuemmler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton startscreen;
        private System.Windows.Forms.RadioButton hallo;
        private System.Windows.Forms.RadioButton pulsator;
        private System.Windows.Forms.RadioButton oktagon;
    }
}

