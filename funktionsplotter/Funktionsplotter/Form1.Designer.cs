namespace Funktionsplotter
{
    partial class Plotter
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
            this.pnl_Grafik = new System.Windows.Forms.Panel();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.txt_xVerschiebung = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.btn_ZoomMinus = new System.Windows.Forms.Button();
            this.btn_ZoomPlus = new System.Windows.Forms.Button();
            this.txt_Zoomfaktor = new System.Windows.Forms.TextBox();
            this.btn_Gitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Gitterabstand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Zeichnen = new System.Windows.Forms.Button();
            this.lbl_Gitterabstand = new System.Windows.Forms.Label();
            this.lbl_Zoomfaktor = new System.Windows.Forms.Label();
            this.txt_XPosition = new System.Windows.Forms.TextBox();
            this.txt_YPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GoTo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_XPosition = new System.Windows.Forms.Label();
            this.lbl_YPosition = new System.Windows.Forms.Label();
            this.btn_Löschen = new System.Windows.Forms.Button();
            this.btn_Cousor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_Grafik
            // 
            this.pnl_Grafik.BackColor = System.Drawing.Color.White;
            this.pnl_Grafik.Location = new System.Drawing.Point(12, 12);
            this.pnl_Grafik.Name = "pnl_Grafik";
            this.pnl_Grafik.Size = new System.Drawing.Size(501, 501);
            this.pnl_Grafik.TabIndex = 0;
            // 
            // txt_x3
            // 
            this.txt_x3.Location = new System.Drawing.Point(518, 12);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.Size = new System.Drawing.Size(100, 20);
            this.txt_x3.TabIndex = 1;
            this.txt_x3.Text = "0";
            // 
            // txt_xVerschiebung
            // 
            this.txt_xVerschiebung.Location = new System.Drawing.Point(518, 90);
            this.txt_xVerschiebung.Name = "txt_xVerschiebung";
            this.txt_xVerschiebung.Size = new System.Drawing.Size(100, 20);
            this.txt_xVerschiebung.TabIndex = 2;
            this.txt_xVerschiebung.Text = "0";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(518, 64);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 3;
            this.txt_x.Text = "0";
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(518, 38);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(100, 20);
            this.txt_x2.TabIndex = 4;
            this.txt_x2.Text = "0";
            // 
            // btn_ZoomMinus
            // 
            this.btn_ZoomMinus.Location = new System.Drawing.Point(518, 487);
            this.btn_ZoomMinus.Name = "btn_ZoomMinus";
            this.btn_ZoomMinus.Size = new System.Drawing.Size(131, 23);
            this.btn_ZoomMinus.TabIndex = 5;
            this.btn_ZoomMinus.Text = "Zoom -";
            this.btn_ZoomMinus.UseVisualStyleBackColor = true;
            this.btn_ZoomMinus.Click += new System.EventHandler(this.btn_ZoomMinus_Click);
            // 
            // btn_ZoomPlus
            // 
            this.btn_ZoomPlus.Location = new System.Drawing.Point(518, 458);
            this.btn_ZoomPlus.Name = "btn_ZoomPlus";
            this.btn_ZoomPlus.Size = new System.Drawing.Size(131, 23);
            this.btn_ZoomPlus.TabIndex = 6;
            this.btn_ZoomPlus.Text = "Zoom +";
            this.btn_ZoomPlus.UseVisualStyleBackColor = true;
            this.btn_ZoomPlus.Click += new System.EventHandler(this.btn_ZoomPlus_Click);
            // 
            // txt_Zoomfaktor
            // 
            this.txt_Zoomfaktor.Location = new System.Drawing.Point(656, 458);
            this.txt_Zoomfaktor.Name = "txt_Zoomfaktor";
            this.txt_Zoomfaktor.Size = new System.Drawing.Size(100, 20);
            this.txt_Zoomfaktor.TabIndex = 7;
            this.txt_Zoomfaktor.Text = "2";
            // 
            // btn_Gitter
            // 
            this.btn_Gitter.Location = new System.Drawing.Point(518, 429);
            this.btn_Gitter.Name = "btn_Gitter";
            this.btn_Gitter.Size = new System.Drawing.Size(131, 23);
            this.btn_Gitter.TabIndex = 8;
            this.btn_Gitter.Text = "Gitter an";
            this.btn_Gitter.UseVisualStyleBackColor = true;
            this.btn_Gitter.Click += new System.EventHandler(this.btn_Gitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "x^3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "y Verschiebung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "x^2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(762, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zoomfaktor    =";
            // 
            // txt_Gitterabstand
            // 
            this.txt_Gitterabstand.Location = new System.Drawing.Point(656, 432);
            this.txt_Gitterabstand.Name = "txt_Gitterabstand";
            this.txt_Gitterabstand.Size = new System.Drawing.Size(100, 20);
            this.txt_Gitterabstand.TabIndex = 17;
            this.txt_Gitterabstand.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gitterabstand =";
            // 
            // btn_Zeichnen
            // 
            this.btn_Zeichnen.Location = new System.Drawing.Point(518, 332);
            this.btn_Zeichnen.Name = "btn_Zeichnen";
            this.btn_Zeichnen.Size = new System.Drawing.Size(131, 23);
            this.btn_Zeichnen.TabIndex = 19;
            this.btn_Zeichnen.Text = "Zeichnen";
            this.btn_Zeichnen.UseVisualStyleBackColor = true;
            this.btn_Zeichnen.Click += new System.EventHandler(this.btn_Zeichnen_Click);
            // 
            // lbl_Gitterabstand
            // 
            this.lbl_Gitterabstand.AutoSize = true;
            this.lbl_Gitterabstand.Location = new System.Drawing.Point(838, 432);
            this.lbl_Gitterabstand.Name = "lbl_Gitterabstand";
            this.lbl_Gitterabstand.Size = new System.Drawing.Size(13, 13);
            this.lbl_Gitterabstand.TabIndex = 20;
            this.lbl_Gitterabstand.Text = "1";
            // 
            // lbl_Zoomfaktor
            // 
            this.lbl_Zoomfaktor.AutoSize = true;
            this.lbl_Zoomfaktor.Location = new System.Drawing.Point(838, 458);
            this.lbl_Zoomfaktor.Name = "lbl_Zoomfaktor";
            this.lbl_Zoomfaktor.Size = new System.Drawing.Size(13, 13);
            this.lbl_Zoomfaktor.TabIndex = 21;
            this.lbl_Zoomfaktor.Text = "1";
            // 
            // txt_XPosition
            // 
            this.txt_XPosition.Location = new System.Drawing.Point(518, 403);
            this.txt_XPosition.Name = "txt_XPosition";
            this.txt_XPosition.Size = new System.Drawing.Size(62, 20);
            this.txt_XPosition.TabIndex = 22;
            this.txt_XPosition.Text = "0";
            // 
            // txt_YPosition
            // 
            this.txt_YPosition.Location = new System.Drawing.Point(587, 403);
            this.txt_YPosition.Name = "txt_YPosition";
            this.txt_YPosition.Size = new System.Drawing.Size(62, 20);
            this.txt_YPosition.TabIndex = 23;
            this.txt_YPosition.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            // 
            // btn_GoTo
            // 
            this.btn_GoTo.Location = new System.Drawing.Point(656, 400);
            this.btn_GoTo.Name = "btn_GoTo";
            this.btn_GoTo.Size = new System.Drawing.Size(100, 23);
            this.btn_GoTo.TabIndex = 25;
            this.btn_GoTo.Text = "GoTo";
            this.btn_GoTo.UseVisualStyleBackColor = true;
            this.btn_GoTo.Click += new System.EventHandler(this.btn_GoTo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Y";
            // 
            // lbl_XPosition
            // 
            this.lbl_XPosition.AutoSize = true;
            this.lbl_XPosition.Location = new System.Drawing.Point(535, 387);
            this.lbl_XPosition.Name = "lbl_XPosition";
            this.lbl_XPosition.Size = new System.Drawing.Size(13, 13);
            this.lbl_XPosition.TabIndex = 27;
            this.lbl_XPosition.Text = "0";
            // 
            // lbl_YPosition
            // 
            this.lbl_YPosition.AutoSize = true;
            this.lbl_YPosition.Location = new System.Drawing.Point(604, 387);
            this.lbl_YPosition.Name = "lbl_YPosition";
            this.lbl_YPosition.Size = new System.Drawing.Size(13, 13);
            this.lbl_YPosition.TabIndex = 28;
            this.lbl_YPosition.Text = "0";
            // 
            // btn_Löschen
            // 
            this.btn_Löschen.Location = new System.Drawing.Point(518, 361);
            this.btn_Löschen.Name = "btn_Löschen";
            this.btn_Löschen.Size = new System.Drawing.Size(131, 23);
            this.btn_Löschen.TabIndex = 29;
            this.btn_Löschen.Text = "Löschen";
            this.btn_Löschen.UseVisualStyleBackColor = true;
            this.btn_Löschen.Click += new System.EventHandler(this.btn_Löschen_Click);
            // 
            // btn_Cousor
            // 
            this.btn_Cousor.Location = new System.Drawing.Point(765, 400);
            this.btn_Cousor.Name = "btn_Cousor";
            this.btn_Cousor.Size = new System.Drawing.Size(100, 23);
            this.btn_Cousor.TabIndex = 30;
            this.btn_Cousor.Text = "Coursor an";
            this.btn_Cousor.UseVisualStyleBackColor = true;
            this.btn_Cousor.Click += new System.EventHandler(this.btn_Cousor_Click);
            // 
            // Plotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 522);
            this.Controls.Add(this.btn_Cousor);
            this.Controls.Add(this.btn_Löschen);
            this.Controls.Add(this.lbl_YPosition);
            this.Controls.Add(this.lbl_XPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_GoTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_YPosition);
            this.Controls.Add(this.txt_XPosition);
            this.Controls.Add(this.lbl_Zoomfaktor);
            this.Controls.Add(this.lbl_Gitterabstand);
            this.Controls.Add(this.btn_Zeichnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Gitterabstand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gitter);
            this.Controls.Add(this.txt_Zoomfaktor);
            this.Controls.Add(this.btn_ZoomPlus);
            this.Controls.Add(this.btn_ZoomMinus);
            this.Controls.Add(this.txt_x2);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.txt_xVerschiebung);
            this.Controls.Add(this.txt_x3);
            this.Controls.Add(this.pnl_Grafik);
            this.Name = "Plotter";
            this.Text = "Plotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Grafik;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.TextBox txt_xVerschiebung;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.Button btn_ZoomMinus;
        private System.Windows.Forms.Button btn_ZoomPlus;
        private System.Windows.Forms.TextBox txt_Zoomfaktor;
        private System.Windows.Forms.Button btn_Gitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Gitterabstand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Zeichnen;
        private System.Windows.Forms.Label lbl_Gitterabstand;
        private System.Windows.Forms.Label lbl_Zoomfaktor;
        private System.Windows.Forms.TextBox txt_XPosition;
        private System.Windows.Forms.TextBox txt_YPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GoTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_XPosition;
        private System.Windows.Forms.Label lbl_YPosition;
        private System.Windows.Forms.Button btn_Löschen;
        private System.Windows.Forms.Button btn_Cousor;
    }
}

