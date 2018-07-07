namespace frm_menu
{
    partial class frm_menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.BTN_retrait = new System.Windows.Forms.Button();
            this.BTN_tranfert = new System.Windows.Forms.Button();
            this.BTN_ajout = new System.Windows.Forms.Button();
            this.BTN_Parametres = new System.Windows.Forms.Button();
            this.LBL_txt_retrait = new System.Windows.Forms.Label();
            this.LBL_txt_transfert = new System.Windows.Forms.Label();
            this.LBL_txt_ajout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_retrait
            // 
            this.BTN_retrait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_retrait.BackgroundImage")));
            this.BTN_retrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_retrait.FlatAppearance.BorderSize = 0;
            this.BTN_retrait.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_retrait.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_retrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_retrait.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_retrait.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_retrait.Location = new System.Drawing.Point(76, 181);
            this.BTN_retrait.Name = "BTN_retrait";
            this.BTN_retrait.Size = new System.Drawing.Size(185, 328);
            this.BTN_retrait.TabIndex = 1;
            this.BTN_retrait.Text = "\r\n\r\n\r\n  Retrait \r\npour usager";
            this.BTN_retrait.UseVisualStyleBackColor = true;
            this.BTN_retrait.Click += new System.EventHandler(this.BTN_retrait_Click);
            // 
            // BTN_tranfert
            // 
            this.BTN_tranfert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_tranfert.BackgroundImage")));
            this.BTN_tranfert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_tranfert.FlatAppearance.BorderSize = 0;
            this.BTN_tranfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_tranfert.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_tranfert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_tranfert.Location = new System.Drawing.Point(292, 181);
            this.BTN_tranfert.Name = "BTN_tranfert";
            this.BTN_tranfert.Size = new System.Drawing.Size(185, 328);
            this.BTN_tranfert.TabIndex = 2;
            this.BTN_tranfert.Text = "  \r\n\r\n\r\n  Transfert \r\n de matériel";
            this.BTN_tranfert.UseVisualStyleBackColor = true;
            this.BTN_tranfert.Click += new System.EventHandler(this.BTN_tranfert_Click);
            // 
            // BTN_ajout
            // 
            this.BTN_ajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_ajout.BackgroundImage")));
            this.BTN_ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ajout.FlatAppearance.BorderSize = 0;
            this.BTN_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ajout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ajout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_ajout.Location = new System.Drawing.Point(509, 181);
            this.BTN_ajout.Name = "BTN_ajout";
            this.BTN_ajout.Size = new System.Drawing.Size(185, 328);
            this.BTN_ajout.TabIndex = 3;
            this.BTN_ajout.Text = "\r\n\r\n\r\n  Ajout \r\nde matériel";
            this.BTN_ajout.UseVisualStyleBackColor = true;
            this.BTN_ajout.Click += new System.EventHandler(this.BTN_ajout_Click);
            // 
            // BTN_Parametres
            // 
            this.BTN_Parametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(184)))), ((int)(((byte)(201)))));
            this.BTN_Parametres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Parametres.BackgroundImage")));
            this.BTN_Parametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Parametres.FlatAppearance.BorderSize = 0;
            this.BTN_Parametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Parametres.Location = new System.Drawing.Point(644, 57);
            this.BTN_Parametres.Name = "BTN_Parametres";
            this.BTN_Parametres.Size = new System.Drawing.Size(50, 50);
            this.BTN_Parametres.TabIndex = 6;
            this.BTN_Parametres.UseVisualStyleBackColor = false;
            this.BTN_Parametres.Click += new System.EventHandler(this.BTN_Parametres_Click);
            // 
            // LBL_txt_retrait
            // 
            this.LBL_txt_retrait.AutoSize = true;
            this.LBL_txt_retrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.LBL_txt_retrait.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txt_retrait.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_txt_retrait.Location = new System.Drawing.Point(87, 433);
            this.LBL_txt_retrait.Name = "LBL_txt_retrait";
            this.LBL_txt_retrait.Size = new System.Drawing.Size(164, 48);
            this.LBL_txt_retrait.TabIndex = 7;
            this.LBL_txt_retrait.Text = "Le matériel ne peut être retiré \r\nqu’en compagnie \r\nd\'un professionnel";
            this.LBL_txt_retrait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_txt_transfert
            // 
            this.LBL_txt_transfert.AutoSize = true;
            this.LBL_txt_transfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.LBL_txt_transfert.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txt_transfert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_txt_transfert.Location = new System.Drawing.Point(310, 433);
            this.LBL_txt_transfert.Name = "LBL_txt_transfert";
            this.LBL_txt_transfert.Size = new System.Drawing.Size(149, 48);
            this.LBL_txt_transfert.TabIndex = 8;
            this.LBL_txt_transfert.Text = "Transfert de matériel de ce \r\nstock vers un autre stock \r\npar un professionel";
            this.LBL_txt_transfert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_txt_ajout
            // 
            this.LBL_txt_ajout.AutoSize = true;
            this.LBL_txt_ajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(230)))), ((int)(((byte)(37)))));
            this.LBL_txt_ajout.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txt_ajout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_txt_ajout.Location = new System.Drawing.Point(514, 433);
            this.LBL_txt_ajout.Name = "LBL_txt_ajout";
            this.LBL_txt_ajout.Size = new System.Drawing.Size(175, 32);
            this.LBL_txt_ajout.TabIndex = 9;
            this.LBL_txt_ajout.Text = "Ajout de matériel dans ce stock \r\npar un professionel";
            this.LBL_txt_ajout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 525);
            this.Controls.Add(this.LBL_txt_ajout);
            this.Controls.Add(this.LBL_txt_transfert);
            this.Controls.Add(this.LBL_txt_retrait);
            this.Controls.Add(this.BTN_Parametres);
            this.Controls.Add(this.BTN_retrait);
            this.Controls.Add(this.BTN_tranfert);
            this.Controls.Add(this.BTN_ajout);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_retrait;
        private System.Windows.Forms.Button BTN_tranfert;
        private System.Windows.Forms.Button BTN_ajout;
        private System.Windows.Forms.Button BTN_Parametres;
        private System.Windows.Forms.Label LBL_txt_retrait;
        private System.Windows.Forms.Label LBL_txt_transfert;
        private System.Windows.Forms.Label LBL_txt_ajout;
    }
}

