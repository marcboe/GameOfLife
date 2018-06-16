using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    //Test
    public partial class Form1 : Form
    {
        public static System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

        private Cell[,] LiveArea;
        private static double turns;


        private void IniLiveArea()
        {
            LiveArea = new Cell[160, 116];
            for (int i = 0; i < 160; i++)
            {
                for (int l = 0; l < 116; l++)
                {
                    LiveArea[i, l] = new Cell();
                }
            }
        }



        public Form1()
        {
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
            if (LiveArea[p.X, p.Y].GetState())
            {
                LiveArea[p.X, p.Y].SetState(false);
            }
            else
            {
                LiveArea[p.X, p.Y].SetState(true);
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
                                if (LiveArea[x, y].GetState()) count++;
                            }
                        }
                    }
                    LiveArea[i, k].SetEnv(count);
                }
            }
            for (int i = 0; i < 160; i++)
            {
                for (int k = 0; k < 116; k++)
                {
                    if ((LiveArea[i, k].GetEnv() == 3) && !LiveArea[i, k].GetState())
                    {
                        LiveArea[i, k].SetState(true);
                    }
                    else
                    {
                        if (LiveArea[i, k].GetEnv() < 2 || LiveArea[i, k].GetEnv() > 3
                        && LiveArea[i, k].GetState())
                        {
                            LiveArea[i, k].SetState(false);
                        }
                    }
                }
            }
            this.Invalidate();
        }

        public void DrawCell(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics draw = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.LightSeaGreen);
            draw.Clear(System.Drawing.SystemColors.Control);

            for (int i = 0; i < 160; i++)
            {
                for (int l = 0; l < 116; l++)
                {
                    if (LiveArea[i, l].GetState())
                    {
                        draw.FillRectangle(brush, i * 5 + 260, l * 5 + 10, 5, 5);
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

        private void buttonLeeren_Click(object sender, EventArgs e)
        {
            IniLiveArea();
            Invalidate();
            this.Text = String.Format("Marc und Peters GameOfLife - Simulation beendet bei Runde {0}.", Math.Round(turns).ToString());
            turns = 1;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            if (trackBarSpeed.Value == 0) timer_1.Interval = 1500;
            else timer_1.Interval = 1000/(trackBarSpeed.Value*trackBarSpeed.Value); 
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

            Invalidate();
        }
    }
}
