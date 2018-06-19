﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConwaysGameOfLife
{
    public partial class Form1 : Form
    {
        public static System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

        private static Cell[,] LiveArea;
        private static double turns;
        // brushDead wird benötigt, um die Farbe toter Zellen zu überschreiben
        private SolidBrush brush = new SolidBrush(Color.LightSeaGreen);
        private SolidBrush brushDead = new SolidBrush(Color.LightGray);

        private ColorDialog c = new ColorDialog();
        private ColorDialog cDead = new ColorDialog();
        // nicht benötigt, Methode wird nicht verwendet. private ColorDialog cBackground = new ColorDialog();

        int alive = 1, dead = 2;

        //Antiwelt setzen
        bool anti = false;

        int[] rule = new int[9];
       
       // 0 = non     1 = birth      2 = kill 
        
        // Regel Array
        private int [] InitRule()
        {
            int x0 = 2, x1 = 2, x2 = 0, x3 = 1, x4 = 2, x5 = 2, x6 = 2, x7 = 2, x8 = 2;
            rule = new int[] { x0, x1, x2, x3, x4, x5, x6, x7, x8 };
            return rule;
        }

        

        private void IniLiveArea()
        {
            LiveArea = new Cell[160, 116];
            for (int i = 0; i < 160; i++)
            {
                for (int l = 0; l < 116; l++)
                {
                    LiveArea[i, l] = new Cell(0, 0);
                }
            }
        }



        public Form1()
        {
            rule = InitRule();
            InitializeComponent();
            IniLiveArea();
            turns = 1;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCell);
            this.Invalidate();
            timer_1.Tick += new EventHandler(Timer_1_Tick);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p = MouseIni(Control.MousePosition);
            /* Testen der Position: Textbox "testBox1" im Form anlegen, um Test-Code ausführen zu können.
             * Test-testBox1.Text = System.String.Format("X: {0} Y: {1}", p.X.ToString(), p.Y.ToString());
            */
            if (LiveArea[p.X, p.Y].State == 1)
            {
                LiveArea[p.X, p.Y].State = 0;
            }
            else
            {
                LiveArea[p.X, p.Y].State = 1;
            }
            this.Invalidate();

        }

        public Point MouseIni(Point p)
        {
            //Die Mausposition wird auf das Zeichenfeld normiert; Es wird in ein 5x5-Raster geteilt, links oben ist 0/0
            //Die Location der Piocture Box wurde auf 260;10 (Punkt der linken oberen Ecke)
            int KoordX = (p.X - this.Location.X - 260 - 8) / 5; // -8 entstehen durch den linken Rand des Fensters
            int KoordY = (p.Y - this.Location.Y - 10 - 31) / 5; // -31 entstehen durch den oberen Rand des Fensters
            p.X = KoordX;
            p.Y = KoordY;
            return p;
        }

        private void Timer_1_Tick(object sender, EventArgs e)
        {
            Animation();
            this.Text = String.Format("Marc und Peters GameOfLife - Simulation läuft. Aktuelle Runde: {0}", Math.Round(turns++).ToString());
        }


        private void Animation()
        {

           
           
            for (int i = 0; i < 160; i++)
            {
                for (int k = 0; k < 116; k++)
                {
                    int x, y, count = 0;
                    for (int a = -1; a <= 1; a++)
                    {
                        for (int b = -1; b <= 1; b++)
                        {
                            x = (i + 160 + a) % 160;
                            y = (k + 116 + b) % 116;
                            if (!(a == 0 && b == 0))
                            {
                                if (LiveArea[x, y].State == 1) count++;
                            }
                        }
                    }
                    LiveArea[i, k].Environment = count;
                }
            }
            for (int i = 0; i < 160; i++)
            {
                for (int k = 0; k < 116; k++)
                {
                    // 0 = empty
                    // 1 = alive
                    // 2 = dead

                    


                    // Normale Welt
                    // kill ?
                    if (LiveArea[i,k].State == alive)           // 0,1,   4,5,6,7,8
                    {
                        
                        if (rule[ LiveArea[i, k].Environment ] == 2)
                            LiveArea[i, k].State = 2;    
                    }
                    // Normale Welt
                    // birth ?
                    if (LiveArea[i, k].State == 0 || LiveArea[i, k].State == dead )
                    {
                        if (rule[ LiveArea[i, k].Environment ] == 1)
                            LiveArea[i, k].State = 1;
                    }
                }
            }

            //Box aktuellem Stand anpassen
            for (int i = 0; i < 9; i++)
            {
                if (rule[i] == 1)
                {
                    checkedListBox2.SetItemChecked(i, true);
                    checkedListBox1.SetItemChecked(i, false);
                }
                else if (rule[i] == 2)
                {
                    checkedListBox1.SetItemChecked(i, true);
                    checkedListBox2.SetItemChecked(i, false);
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, false);
                    checkedListBox2.SetItemChecked(i, false);
                }

            }

                this.Invalidate();
        }
       
       

        public void DrawCell(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics draw = e.Graphics;
            draw.Clear(System.Drawing.SystemColors.Control);

            for (int i = 0; i < 160; i++)
            {
                for (int l = 0; l < 116; l++)
                {
                    if (LiveArea[i, l].State == 1)
                    {
                        draw.FillRectangle(brush, i * 5 + 260, l * 5 + 10, 5, 5);
                    }
                    else if (LiveArea[i, l].State == 2)
                    {
                        draw.FillRectangle(brushDead, i * 5 + 260, l * 5 + 10, 5, 5);
                    }
                }
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            {
                if (!timer_1.Enabled)
                {
                    timer_1.Enabled = true;
                    timer_1.Start();
                    buttonStart.Text = "Stopp";
                }
                else
                {
                    timer_1.Enabled = false;
                    timer_1.Stop();
                    buttonStart.Text = "Start";
                    this.Text = String.Format("Marc und Peters GameOfLife - Simulation beendet bei Runde {0}.",Math.Round(turns).ToString());
                }
            }
        }

        private void changeSet_Click(object sender, EventArgs e)
        {
            // Births auslesen
            for (int i =0; i< 9; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                    if (!checkedListBox1.GetItemChecked(i))
                        rule[i] = 1;
                    else
                    {
                        MessageBox.Show(" Bitte Möglichkeiten nicht doppelt belegen!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            // Kills auslesen
            for (int i = 0; i < 9; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    if (!checkedListBox2.GetItemChecked(i))
                        rule[i] = 2;
                    else
                    {
                        MessageBox.Show(" Bitte Möglichkeiten nicht doppelt belegen!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                
                
            }

            // leere Boxen auslesen
            for (int i = 0; i < 9; i++)
            {
                if (!checkedListBox1.GetItemChecked(i))
                    if (!checkedListBox2.GetItemChecked(i))
                        rule[i] = 0;
            }

            MessageBox.Show("Einstellungen wurden übernommen", "Fertig", MessageBoxButtons.OK, MessageBoxIcon.Information);


            for (int i = 0; i < 9; i++)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int i = 0; i < 9; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void resetChange_Click(object sender, EventArgs e)
        {
            anti = false;
            InitRule();
            antiwelt.Text = "Antiwelt";

            this.Invalidate();

        }

        private void buttonLeeren_Click(object sender, EventArgs e)
        {
            IniLiveArea();
            Invalidate();
            this.Text = String.Format("Marc und Peters GameOfLife - Simulation beendet bei Runde {0}.", Math.Round(turns).ToString());
            turns = 1;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            if (trackBarSpeed.Value == 0) timer_1.Interval = 1000;
            else timer_1.Interval = 1000-(95*trackBarSpeed.Value); 
        }

        private void buttonEinzelschritt_Click(object sender, EventArgs e)
        {
            if (timer_1.Enabled)
            {
                timer_1.Stop();
                buttonStart.Text = "Weiter";
            }
            else
            {
                Animation();
                this.Text = String.Format("Marc und Peters GameOfLife - Simulation läuft. Aktuelle Runde: {0}", Math.Round(turns++).ToString());
            }
        }

        private void farbenEinstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.ShowDialog();
            brush = new SolidBrush(c.Color);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCell);
            Invalidate();
        }

        private void zellfFarbetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDead.ShowDialog();
            brushDead = new SolidBrush(cDead.Color);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCell);
            Invalidate();
        }

        private void spielfeldSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cell c;
            using (FileStream fs = new FileStream(@"loadouts.obj", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < 160; i++)
                    {
                        for (int l = 0; l < 116; l++)
                        {
                            c = LiveArea[i, l];
                            sw.WriteLine(c.State);
                        }
                    }
                }
            }
        }

        private void spielfeldLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.IO.FileStream fs = new FileStream(@"loadouts.obj", FileMode.Open, FileAccess.Read))
            {
                TextReader reader = new StreamReader(fs);
                for (int i = 0; i < 160; i++)
                {
                    for (int l = 0; l < 116; l++)
                    {
                        string c = reader.ReadLine();
                        if (c == "0") LiveArea[i, l].State = 0;
                        else if (c == "1") LiveArea[i, l].State = 1;
                        else LiveArea[i, l].State = 2;
                    }
                }
            }
            Invalidate();
        }

        private void antiwelt_Click(object sender, EventArgs e)
        {
            turnWorld();
            if (anti)
                antiwelt.Text = "Normal";
            if (!anti)
                antiwelt.Text = "Antiwelt";
        }

        private bool turnWorld()
        {
            int change = alive;
            alive = dead;
            dead = change;

            int[] ruleChange  = new int [9];
            
            for (int i=0; i<9; i++)
            {
                ruleChange[8 - i] = rule[i];
            }

            for (int i = 0; i < 9; i++)
            {
                if (ruleChange[i] == 2)
                    ruleChange[i] = 1;
                else
                    if (ruleChange[i] == 1)
                        ruleChange[i] = 2;
            }
            rule = ruleChange;


            anti = !anti;
            return anti;

        }

        /*
         * Die Methode macht Schwierigkeiten: Nach dem Ändern der Hintergrundfarbe verschwinden gezeichnete Punkte und tauchen nicht wieder auf. 
         * Ist nicht in der Aufgabenstellung gefordert -> Raus
        private void HintergrundFarbeToolStrip(object sender, EventArgs e)
        {
            cBackground.ShowDialog();
            pictureBox1.BackColor = cBackground.Color;
            Invalidate();
        }
        */
    }
}
