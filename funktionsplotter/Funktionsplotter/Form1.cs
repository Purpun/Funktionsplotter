using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funktionsplotter
{
    public partial class Plotter : Form
    {
        double[] xWert = new double[4];
        double[] Funktion1_xWert = new double[4];
        double[] Funktion2_xWert = new double[4];
        double[] Funktion3_xWert = new double[4];
        double[] Funktion4_xWert = new double[4];
        double[] tmpxWert = new double[4];
        double Zoomfaktor = 32;
        double tmpZoomfaktor;
        double GitterZoomfaktor = 32;
        double XCoursor, YCoursor;
        double Gitterabstand;
        double tmpGitterabstand = 1;
        int Coursor_Size = 16;
        int argb;
        int Grafik_Anzahl;
        int Durchläufe;
        bool xWert_enabled = false;
        bool Gitterabstand_enabled;
        bool btn_Gitter_Pressed = false;
        bool btn_Cousor_Pressed = false;
        bool Main_Anzeigen = false;
        bool pnlRefresh = true;
        bool pnlClear = false;
        bool Grafikfirstuse = false;
        bool Fixpunkt_enabled = false;

        public Plotter()
        {
            InitializeComponent();
        }

        private void main()
        {
            Fixpunkt();
            Graphics g;
            g = pnl_Grafik.CreateGraphics();
            if (pnlRefresh == true)
            {
                pnl_Grafik.Refresh();
            }
            Gitter(g);
            Grafik(g);
            Coursor(g);
            if (pnlClear == true)
            {
                pnl_Grafik.Refresh();
            }
            pnlRefresh = true;
            pnlClear = false;
        }

        private void xWerte()
        {
            if (xWert_enabled == true)
            {
                tmpxWert[3] = Convert.ToDouble(txt_x3.Text);
                tmpxWert[2] = Convert.ToDouble(txt_x2.Text);
                tmpxWert[1] = Convert.ToDouble(txt_x.Text);
                tmpxWert[0] = Convert.ToDouble(txt_xVerschiebung.Text);
                xWert_enabled = false;
            }
            xWert[3] = tmpxWert[3] / (Zoomfaktor * Zoomfaktor);
            xWert[2] = tmpxWert[2] / Zoomfaktor;
            xWert[1] = tmpxWert[1];
            xWert[0] = tmpxWert[0] * Zoomfaktor;
        }

        private void Speichern()
        {
            if (CBox_Funktion1.Checked == true)
            {
                Funktion1_xWert[3] = xWert[3] * (Zoomfaktor * Zoomfaktor);
                Funktion1_xWert[2] = xWert[2] * Zoomfaktor;
                Funktion1_xWert[1] = xWert[1];
                Funktion1_xWert[0] = xWert[0] / Zoomfaktor;
            }

            if (CBox_Funktion2.Checked == true)
            {
                Funktion2_xWert[3] = xWert[3] * (Zoomfaktor * Zoomfaktor);
                Funktion2_xWert[2] = xWert[2] * Zoomfaktor;
                Funktion2_xWert[1] = xWert[1];
                Funktion2_xWert[0] = xWert[0] / Zoomfaktor;
            }

            if (CBox_Funktion3.Checked == true)
            {
                Funktion3_xWert[3] = xWert[3] * (Zoomfaktor * Zoomfaktor);
                Funktion3_xWert[2] = xWert[2] * Zoomfaktor;
                Funktion3_xWert[1] = xWert[1];
                Funktion3_xWert[0] = xWert[0] / Zoomfaktor;
            }

            if (CBox_Funktion4.Checked == true)
            {
                Funktion4_xWert[3] = xWert[3] * (Zoomfaktor * Zoomfaktor);
                Funktion4_xWert[2] = xWert[2] * Zoomfaktor;
                Funktion4_xWert[1] = xWert[1];
                Funktion4_xWert[0] = xWert[0] / Zoomfaktor;
            }
        }

        private void MainAnzeigen()
        {
            if (Main_Anzeigen == true)
            {
                Anzeigen();
            }
            else
            {
                Grafik_Anzahl = 1;
                main();
            }
        }

        private void Grafik(Graphics g)
        {
            if (Grafikfirstuse == true)
            {
                int NextGrafik = 0;
                while (Durchläufe != Grafik_Anzahl)
                {
                    if (Main_Anzeigen == true)
                    {
                        if (NextGrafik == 0)
                        {
                            if (CBox_Funktion1.Checked == true)
                            {
                                xWert[3] = Funktion1_xWert[3] / (Zoomfaktor * Zoomfaktor);
                                xWert[2] = Funktion1_xWert[2] / Zoomfaktor;
                                xWert[1] = Funktion1_xWert[1];
                                xWert[0] = Funktion1_xWert[0] * Zoomfaktor;
                                argb = Color.DodgerBlue.ToArgb();
                            }
                        }
                        if (NextGrafik == 1)
                        {
                            if (CBox_Funktion2.Checked == true)
                            {
                                xWert[3] = Funktion2_xWert[3] / (Zoomfaktor * Zoomfaktor);
                                xWert[2] = Funktion2_xWert[2] / Zoomfaktor;
                                xWert[1] = Funktion2_xWert[1];
                                xWert[0] = Funktion2_xWert[0] * Zoomfaktor;
                                argb = Color.MediumSeaGreen.ToArgb();
                            }
                        }
                        if (NextGrafik == 2)
                        {
                            if (CBox_Funktion3.Checked == true)
                            {
                                xWert[3] = Funktion3_xWert[3] / (Zoomfaktor * Zoomfaktor);
                                xWert[2] = Funktion3_xWert[2] / Zoomfaktor;
                                xWert[1] = Funktion3_xWert[1];
                                xWert[0] = Funktion3_xWert[0] * Zoomfaktor;
                                argb = Color.Gold.ToArgb();
                            }
                        }
                        if (NextGrafik == 3)
                        {
                            if (CBox_Funktion4.Checked == true)
                            {
                                xWert[3] = Funktion4_xWert[3] / (Zoomfaktor * Zoomfaktor);
                                xWert[2] = Funktion4_xWert[2] / Zoomfaktor;
                                xWert[1] = Funktion4_xWert[1];
                                xWert[0] = Funktion4_xWert[0] * Zoomfaktor;
                                argb = Color.OrangeRed.ToArgb();
                            }
                        }
                    }
                    else
                    {
                        xWerte();
                        argb = Color.LightSlateGray.ToArgb();
                    }
                    double[] x = new double[2];
                    double[] X = new double[2];
                    double[] Y = new double[2];
                    for (x[0] = (-pnl_Grafik.Width / 2) + XCoursor; x[0] <= (pnl_Grafik.Width / 2) + XCoursor; x[0] += 1)
                    {
                        x[1] = x[0] + 1;
                        X[0] = pnl_Grafik.Width / 2 + x[0] - XCoursor;
                        X[1] = pnl_Grafik.Width / 2 + (x[0] + 1) - XCoursor;
                        Y[0] = pnl_Grafik.Width / 2 - ((xWert[3] * x[0] * x[0] * x[0]) + (xWert[2] * x[0] * x[0]) + (xWert[1] * x[0]) + (xWert[0]) + YCoursor);
                        Y[1] = pnl_Grafik.Width / 2 - ((xWert[3] * x[1] * x[1] * x[1]) + (xWert[2] * x[1] * x[1]) + (xWert[1] * x[1]) + (xWert[0]) + YCoursor);
                        g.DrawLine(new Pen(Color.FromArgb(argb)), (int)X[0], (int)Y[0], (int)X[1], (int)Y[1]);

                        if ((int)X[0] == 0)
                        {
                            g.DrawLine(new Pen(Color.DarkTurquoise), pnl_Grafik.Width / 2 - (int)XCoursor, 0, pnl_Grafik.Width / 2 - (int)XCoursor, pnl_Grafik.Height);
                            g.DrawLine(new Pen(Color.DarkTurquoise), 0, pnl_Grafik.Height / 2 - (int)YCoursor, pnl_Grafik.Width, pnl_Grafik.Height / 2 - (int)YCoursor);
                        }
                    }
                    NextGrafik += 1;
                    Durchläufe += 1;
                }
                Durchläufe = 0;
            }
        }

        private void Gitter(Graphics g)
        {
            if (btn_Gitter_Pressed == true)
            {
                if (Gitterabstand_enabled == true)
                {
                    tmpGitterabstand = Convert.ToDouble(txt_Gitterabstand.Text);
                }

                Gitterabstand = tmpGitterabstand * Zoomfaktor;

                for (double xGitter = pnl_Grafik.Width / 2 - XCoursor; xGitter <= pnl_Grafik.Width + XCoursor; xGitter = xGitter + Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                }
                for (double xGitter = pnl_Grafik.Width / 2 - XCoursor; xGitter >= 0 - XCoursor; xGitter = xGitter - Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                }
                for (double yGitter = pnl_Grafik.Height / 2 - YCoursor; yGitter <= pnl_Grafik.Height - YCoursor; yGitter = yGitter + Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                for (double yGitter = pnl_Grafik.Height / 2 - YCoursor; yGitter >= 0 + YCoursor; yGitter = yGitter - Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                GitterZoomfaktor = Zoomfaktor;
                lbl_Gitterabstand.Text = Convert.ToString(Gitterabstand/Zoomfaktor);
                btn_Gitter.Text = "Gitter aus / ändern";
            }
            else if (tmpGitterabstand != Convert.ToDouble(txt_Gitterabstand.Text) || Zoomfaktor != GitterZoomfaktor)
            {
                pnl_Grafik.Refresh();

                if (Gitterabstand_enabled == true)
                {
                    tmpGitterabstand = Convert.ToDouble(txt_Gitterabstand.Text);
                }
                Gitterabstand = tmpGitterabstand * Zoomfaktor;

                for (double xGitter = pnl_Grafik.Width / 2; xGitter <= pnl_Grafik.Width; xGitter = xGitter + Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                }
                for (double xGitter = pnl_Grafik.Width / 2; xGitter >= 0; xGitter = xGitter - Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                }
                for (double yGitter = pnl_Grafik.Height / 2; yGitter <= pnl_Grafik.Height; yGitter = yGitter + Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                for (double yGitter = pnl_Grafik.Height / 2; yGitter >= 0; yGitter = yGitter - Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                GitterZoomfaktor = Zoomfaktor;
                lbl_Gitterabstand.Text = Convert.ToString(Gitterabstand/Zoomfaktor);
                btn_Gitter.Text = "Gitter aus / ändern";
            }
            else if (btn_Gitter_Pressed == false)
            {
                if (pnlRefresh == true)
                {
                    pnl_Grafik.Refresh();
                }
                btn_Gitter.Text = "Gitter an";
            }
            Gitterabstand_enabled = false;
        }

        private void Fixpunkt()
        {
                XCoursor = Convert.ToDouble(txt_XPosition.Text) * Zoomfaktor;
                YCoursor = -Convert.ToDouble(txt_YPosition.Text) * Zoomfaktor;
                lbl_XPosition.Text = txt_XPosition.Text;
                lbl_YPosition.Text = txt_YPosition.Text;
        }

        private void Anzeigen()
        {
            pnlClear = true;
            main();
            if (CBox_Funktion1.Checked == true)
            {
                Grafik_Anzahl += 1;
            }

            if (CBox_Funktion2.Checked == true)
            {
                Grafik_Anzahl += 1;
            }

            if (CBox_Funktion3.Checked == true)
            {
                Grafik_Anzahl += 1;
            }

            if (CBox_Funktion4.Checked == true)
            {
                Grafik_Anzahl += 1;
            }
            pnlRefresh = false;
            main();
            Grafik_Anzahl = 0;
        }

        private void Coursor(Graphics g)
        {
            if (btn_Cousor_Pressed == true)
            { 
                g.DrawLine(new Pen(Color.Orange), pnl_Grafik.Width / 2 - Coursor_Size, pnl_Grafik.Height / 2 - Coursor_Size, pnl_Grafik.Width / 2 - Coursor_Size / 2, pnl_Grafik.Height / 2 - Coursor_Size / 2);
                g.DrawLine(new Pen(Color.Orange), pnl_Grafik.Width / 2 - Coursor_Size, pnl_Grafik.Height / 2 + Coursor_Size, pnl_Grafik.Width / 2 - Coursor_Size / 2, pnl_Grafik.Height / 2 + Coursor_Size / 2);
                g.DrawLine(new Pen(Color.Orange), pnl_Grafik.Width / 2 + Coursor_Size, pnl_Grafik.Height / 2 - Coursor_Size, pnl_Grafik.Width / 2 + Coursor_Size / 2, pnl_Grafik.Height / 2 - Coursor_Size / 2);
                g.DrawLine(new Pen(Color.Orange), pnl_Grafik.Width / 2 + Coursor_Size, pnl_Grafik.Height / 2 + Coursor_Size, pnl_Grafik.Width / 2 + Coursor_Size / 2, pnl_Grafik.Height / 2 + Coursor_Size / 2);
            }
        }

        private void btn_Gitter_Click(object sender, EventArgs e)
        {
            btn_Gitter_Pressed = !btn_Gitter_Pressed;
            Gitterabstand_enabled = true;
            MainAnzeigen();
        }

        private void btn_Zeichnen_Click(object sender, EventArgs e)
        {
            xWert_enabled = true;
            Grafikfirstuse = true;
            Main_Anzeigen = false;
            MainAnzeigen();
        }

        private void btn_ZoomPlus_Click(object sender, EventArgs e)
        {
            if (Zoomfaktor <= 2147483647)
            {
                if (tmpZoomfaktor == Convert.ToDouble(txt_Zoomfaktor.Text))
                {
                    Zoomfaktor *= Convert.ToDouble(txt_Zoomfaktor.Text);
                    lbl_Zoomfaktor.Text = Convert.ToString(Convert.ToDouble(lbl_Zoomfaktor.Text) * Convert.ToDouble(txt_Zoomfaktor.Text));
                }
                else
                {
                    Zoomfaktor = 32 * Convert.ToDouble(txt_Zoomfaktor.Text);
                    lbl_Zoomfaktor.Text = Convert.ToString(Convert.ToDouble(txt_Zoomfaktor.Text));
                }
                tmpZoomfaktor = Convert.ToDouble(txt_Zoomfaktor.Text);
            }
            MainAnzeigen();
        }

        private void btn_ZoomMinus_Click(object sender, EventArgs e)
        {
            if (Zoomfaktor > 0)
            {
                if (tmpZoomfaktor == Convert.ToDouble(txt_Zoomfaktor.Text))
                {
                    Zoomfaktor /= Convert.ToDouble(txt_Zoomfaktor.Text);
                    lbl_Zoomfaktor.Text = Convert.ToString(Convert.ToDouble(lbl_Zoomfaktor.Text) / Convert.ToDouble(txt_Zoomfaktor.Text));
                }
                else
                {
                    Zoomfaktor = 32/Convert.ToDouble(txt_Zoomfaktor.Text);
                    lbl_Zoomfaktor.Text = Convert.ToString(Convert.ToDouble(txt_Zoomfaktor.Text));
                }
                tmpZoomfaktor = Convert.ToDouble(txt_Zoomfaktor.Text);
            }
            MainAnzeigen();
        }

        private void btn_GoTo_Click(object sender, EventArgs e)
        {
            MainAnzeigen();
        }

        private void btn_Löschen_Click(object sender, EventArgs e)
        {
            pnl_Grafik.Refresh();
            tmpxWert[3] = 0;
            tmpxWert[2] = 0;
            tmpxWert[1] = 0;
            tmpxWert[0] = 0;
            Zoomfaktor = 32;
            lbl_Zoomfaktor.Text = "1";
        }

        private void btn_Cousor_Click(object sender, EventArgs e)
        {
            btn_Cousor_Pressed = !btn_Cousor_Pressed;
            MainAnzeigen();
        }

        private void btn_Anzeigen_Click(object sender, EventArgs e)
        {
            Main_Anzeigen = true;
            Grafikfirstuse = true;
            MainAnzeigen();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            Speichern();
        }
    }
}
