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
        double[] tmpxWert = new double[4];
        double Zoomfaktor = 32;
        double tmpZoomfaktor;
        double XCoursor, YCoursor;
        double Gitterabstand;
        double tmpGitterabstand;
        int Coursor_Size = 16;
        bool xWert_enabled = false;
        bool Gitterabstand_enabled;
        bool btn_Gitter_Pressed = false;
        bool btn_Cousor_Pressed = false;

        public Plotter()
        {
            InitializeComponent();
        }

        private void main()
        {
            xWerte();
            Fixpunkt();
            Graphics g;
            g = pnl_Grafik.CreateGraphics();
            pnl_Grafik.Refresh();
            Gitter(g);
            Grafik(g);
            Coursor(g);
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

        private void Grafik(Graphics g)
        { 
            double[] x = new double[2];
            double[] X = new double[2];
            double[] Y = new double[2];
            for (x[0] = (-pnl_Grafik.Width / 2) + XCoursor; x[0] <= (pnl_Grafik.Width / 2) + XCoursor; x[0] += 1)
            {
                x[1] = x[0] + 1;
                X[0] = pnl_Grafik.Width/2 + x[0]-XCoursor;
                X[1] = pnl_Grafik.Width/2 + (x[0] + 1)-XCoursor;
                Y[0] = pnl_Grafik.Width/2 - ((xWert[3] * x[0] * x[0] * x[0]) + (xWert[2] * x[0] * x[0]) + (xWert[1] * x[0]) + (xWert[0]) + YCoursor);
                Y[1] = pnl_Grafik.Width/2 - ((xWert[3] * x[1] * x[1] * x[1]) + (xWert[2] * x[1] * x[1]) + (xWert[1] * x[1]) + (xWert[0]) + YCoursor);
                g.DrawLine(new Pen(Color.Blue), (int)X[0], (int)Y[0], (int)X[1], (int)Y[1]);

                if ((int)X[0] == 0)
                {
                    g.DrawLine(new Pen(Color.Red),pnl_Grafik.Width / 2 - (int)XCoursor, 0, pnl_Grafik.Width / 2 - (int)XCoursor, pnl_Grafik.Height);
                    g.DrawLine(new Pen(Color.Red), 0, pnl_Grafik.Height / 2 - (int)YCoursor, pnl_Grafik.Width, pnl_Grafik.Height / 2 - (int)YCoursor);
                }
            }
        }

        private void Gitter(Graphics g)
        {
            Gitterabstand = tmpGitterabstand * Zoomfaktor;
            if (btn_Gitter_Pressed == true)
            {
                if (Gitterabstand_enabled == true)
                {
                    tmpGitterabstand = Convert.ToDouble(txt_Gitterabstand.Text);
                }

                Gitterabstand = tmpGitterabstand * Zoomfaktor;

                for (double xGitter = pnl_Grafik.Width / 2 - XCoursor; xGitter <= pnl_Grafik.Width + XCoursor; xGitter = xGitter + Gitterabstand)
                {
                    if (xGitter != pnl_Grafik.Width / 2 - XCoursor)
                    {
                        g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                    }
                }
                for (double xGitter = pnl_Grafik.Width / 2 - XCoursor; xGitter >= 0 - XCoursor; xGitter = xGitter - Gitterabstand)
                {
                    if (xGitter != pnl_Grafik.Width / 2 - XCoursor)
                    {
                        g.DrawLine(new Pen(Color.Black), (int)xGitter, 0, (int)xGitter, pnl_Grafik.Height);
                    }
                }
                for (double yGitter = pnl_Grafik.Height / 2 - YCoursor; yGitter <= pnl_Grafik.Height - YCoursor; yGitter = yGitter + Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                for (double yGitter = pnl_Grafik.Height / 2 - YCoursor; yGitter >= 0 + YCoursor; yGitter = yGitter - Gitterabstand)
                {
                    g.DrawLine(new Pen(Color.Black), 0, (int)yGitter, pnl_Grafik.Width, (int)yGitter);
                }
                lbl_Gitterabstand.Text = Convert.ToString(Gitterabstand/Zoomfaktor);
                btn_Gitter.Text = "Gitter aus / ändern";
            }
            else if (Gitterabstand != Convert.ToDouble(txt_Gitterabstand.Text)*Zoomfaktor && Gitterabstand != 0)
            {
                pnl_Grafik.Refresh();

                if (Gitterabstand_enabled == true)
                {
                    tmpGitterabstand = Convert.ToDouble(txt_Gitterabstand.Text) * Zoomfaktor;
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
                lbl_Gitterabstand.Text = Convert.ToString(Gitterabstand/Zoomfaktor);
                btn_Gitter.Text = "Gitter aus / ändern";
            }
            else if (btn_Gitter_Pressed == false)
            {
                pnl_Grafik.Refresh();
                btn_Gitter.Text = "Gitter an";
            }
            Gitterabstand_enabled = false;
        }

        private void Fixpunkt()
        {
            XCoursor = Convert.ToDouble(txt_XPosition.Text)*Zoomfaktor;
            YCoursor = -Convert.ToDouble(txt_YPosition.Text)*Zoomfaktor;
            lbl_XPosition.Text = txt_XPosition.Text;
            lbl_YPosition.Text = txt_YPosition.Text;
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
            main();
        }

        private void btn_Zeichnen_Click(object sender, EventArgs e)
        {
            xWert_enabled = true;
            main();
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
            main();
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
            main();
        }

        private void btn_GoTo_Click(object sender, EventArgs e)
        {
            main();
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
            main();
        }
    }
}
