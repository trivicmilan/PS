﻿namespace PS
{
    partial class AdminMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMeni));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLinijeLista = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDodavanjeZaposlenog = new System.Windows.Forms.Button();
            this.btnDodavanjePoslovnice = new System.Windows.Forms.Button();
            this.btnDodavanjeLinije = new System.Windows.Forms.Button();
            this.lblLinijePregled = new System.Windows.Forms.Label();
            this.btnPregledNaloga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dodavanje linije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dodavanje poslovnice";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodavanje korisničkog naloga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odjava";
            // 
            // btnLinijeLista
            // 
            this.btnLinijeLista.BackgroundImage = global::PS.Properties.Resources.location;
            this.btnLinijeLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinijeLista.Location = new System.Drawing.Point(22, 157);
            this.btnLinijeLista.Name = "btnLinijeLista";
            this.btnLinijeLista.Size = new System.Drawing.Size(108, 88);
            this.btnLinijeLista.TabIndex = 8;
            this.btnLinijeLista.UseVisualStyleBackColor = true;
            this.btnLinijeLista.Click += new System.EventHandler(this.btnLinijeLista_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdjava.BackgroundImage")));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.Location = new System.Drawing.Point(357, 157);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(108, 88);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDodavanjeZaposlenog
            // 
            this.btnDodavanjeZaposlenog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodavanjeZaposlenog.BackgroundImage")));
            this.btnDodavanjeZaposlenog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjeZaposlenog.Location = new System.Drawing.Point(191, 12);
            this.btnDodavanjeZaposlenog.Name = "btnDodavanjeZaposlenog";
            this.btnDodavanjeZaposlenog.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjeZaposlenog.TabIndex = 2;
            this.btnDodavanjeZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodavanjeZaposlenog.Click += new System.EventHandler(this.btnDodavanjeZaposlenog_Click);
            // 
            // btnDodavanjePoslovnice
            // 
            this.btnDodavanjePoslovnice.BackgroundImage = global::PS.Properties.Resources.poslovnica;
            this.btnDodavanjePoslovnice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjePoslovnice.Location = new System.Drawing.Point(357, 12);
            this.btnDodavanjePoslovnice.Name = "btnDodavanjePoslovnice";
            this.btnDodavanjePoslovnice.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjePoslovnice.TabIndex = 1;
            this.btnDodavanjePoslovnice.UseVisualStyleBackColor = true;
            this.btnDodavanjePoslovnice.Click += new System.EventHandler(this.btnDodavanjePoslovnice_Click);
            // 
            // btnDodavanjeLinije
            // 
            this.btnDodavanjeLinije.BackgroundImage = global::PS.Properties.Resources.linija1;
            this.btnDodavanjeLinije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjeLinije.Location = new System.Drawing.Point(22, 12);
            this.btnDodavanjeLinije.Name = "btnDodavanjeLinije";
            this.btnDodavanjeLinije.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjeLinije.TabIndex = 0;
            this.btnDodavanjeLinije.UseVisualStyleBackColor = true;
            this.btnDodavanjeLinije.Click += new System.EventHandler(this.btnDodavanjeLinije_Click);
            // 
            // lblLinijePregled
            // 
            this.lblLinijePregled.AutoSize = true;
            this.lblLinijePregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinijePregled.Location = new System.Drawing.Point(27, 248);
            this.lblLinijePregled.Name = "lblLinijePregled";
            this.lblLinijePregled.Size = new System.Drawing.Size(103, 15);
            this.lblLinijePregled.TabIndex = 9;
            this.lblLinijePregled.Text = "Pregled svih linija";
            // 
            // btnPregledNaloga
            // 
            this.btnPregledNaloga.BackgroundImage = global::PS.Properties.Resources.korisnik;
            this.btnPregledNaloga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPregledNaloga.Location = new System.Drawing.Point(191, 157);
            this.btnPregledNaloga.Name = "btnPregledNaloga";
            this.btnPregledNaloga.Size = new System.Drawing.Size(108, 88);
            this.btnPregledNaloga.TabIndex = 10;
            this.btnPregledNaloga.UseVisualStyleBackColor = true;
            this.btnPregledNaloga.Click += new System.EventHandler(this.btnPregledNaloga_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prikaz korisničkih naloga";
            // 
            // AdminMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPregledNaloga);
            this.Controls.Add(this.lblLinijePregled);
            this.Controls.Add(this.btnLinijeLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodavanjeZaposlenog);
            this.Controls.Add(this.btnDodavanjePoslovnice);
            this.Controls.Add(this.btnDodavanjeLinije);
            this.Name = "AdminMeni";
            this.Text = "Pošte Srpske - Admin meni";
            this.Load += new System.EventHandler(this.AdminMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodavanjeLinije;
        private System.Windows.Forms.Button btnDodavanjePoslovnice;
        private System.Windows.Forms.Button btnDodavanjeZaposlenog;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLinijeLista;
        private System.Windows.Forms.Label lblLinijePregled;
        private System.Windows.Forms.Button btnPregledNaloga;
        private System.Windows.Forms.Label label5;
    }
}