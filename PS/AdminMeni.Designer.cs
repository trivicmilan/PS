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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDodavanjeZaposlenog = new System.Windows.Forms.Button();
            this.btnDodavanjePoslovnice = new System.Windows.Forms.Button();
            this.btnDodavanjeLinije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdjava.BackgroundImage")));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.Location = new System.Drawing.Point(191, 157);
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
            this.btnDodavanjeZaposlenog.Location = new System.Drawing.Point(22, 157);
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
            this.btnDodavanjePoslovnice.Location = new System.Drawing.Point(191, 12);
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
            // AdminMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 298);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodavanjeZaposlenog);
            this.Controls.Add(this.btnDodavanjePoslovnice);
            this.Controls.Add(this.btnDodavanjeLinije);
            this.Name = "AdminMeni";
            this.Text = "AdminMeni";
            this.Load += new System.EventHandler(this.AdminMeni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodavanjeLinije;
        private System.Windows.Forms.Button btnDodavanjePoslovnice;
        private System.Windows.Forms.Button btnDodavanjeZaposlenog;
        private System.Windows.Forms.Button btnOdjava;
    }
}