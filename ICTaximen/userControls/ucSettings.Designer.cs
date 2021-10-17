namespace ICTaximen.userControls
{
    partial class ucSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAttribuer = new System.Windows.Forms.Button();
            this.btnAssoociation = new System.Windows.Forms.Button();
            this.btnAssociation = new System.Windows.Forms.Button();
            this.btnCategorieEngin = new System.Windows.Forms.Button();
            this.btnParameter = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFonction = new System.Windows.Forms.Button();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnAttribuer);
            this.panel1.Controls.Add(this.btnAssoociation);
            this.panel1.Controls.Add(this.btnAssociation);
            this.panel1.Controls.Add(this.btnCategorieEngin);
            this.panel1.Controls.Add(this.btnParameter);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnFonction);
            this.panel1.Controls.Add(this.btnUtilisateur);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 510);
            this.panel1.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReport.Image = global::ICTaximen.Properties.Resources.report_64;
            this.btnReport.Location = new System.Drawing.Point(452, 343);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 109);
            this.btnReport.TabIndex = 25;
            this.btnReport.Text = "Rapport";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAttribuer
            // 
            this.btnAttribuer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttribuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAttribuer.FlatAppearance.BorderSize = 0;
            this.btnAttribuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttribuer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttribuer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAttribuer.Image = global::ICTaximen.Properties.Resources.fonction_32;
            this.btnAttribuer.Location = new System.Drawing.Point(62, 63);
            this.btnAttribuer.Name = "btnAttribuer";
            this.btnAttribuer.Size = new System.Drawing.Size(326, 129);
            this.btnAttribuer.TabIndex = 24;
            this.btnAttribuer.Text = "Attribuer Fonction";
            this.btnAttribuer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttribuer.UseVisualStyleBackColor = false;
            this.btnAttribuer.Click += new System.EventHandler(this.btnAttribuer_Click);
            // 
            // btnAssoociation
            // 
            this.btnAssoociation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssoociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAssoociation.FlatAppearance.BorderSize = 0;
            this.btnAssoociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssoociation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssoociation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAssoociation.Image = global::ICTaximen.Properties.Resources.ville_32;
            this.btnAssoociation.Location = new System.Drawing.Point(62, 344);
            this.btnAssoociation.Name = "btnAssoociation";
            this.btnAssoociation.Size = new System.Drawing.Size(245, 109);
            this.btnAssoociation.TabIndex = 23;
            this.btnAssoociation.Text = "Association";
            this.btnAssoociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssoociation.UseVisualStyleBackColor = false;
            this.btnAssoociation.Click += new System.EventHandler(this.btnAssoociation_Click);
            // 
            // btnAssociation
            // 
            this.btnAssociation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAssociation.FlatAppearance.BorderSize = 0;
            this.btnAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssociation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAssociation.Image = global::ICTaximen.Properties.Resources.ville_32;
            this.btnAssociation.Location = new System.Drawing.Point(62, 203);
            this.btnAssociation.Name = "btnAssociation";
            this.btnAssociation.Size = new System.Drawing.Size(162, 129);
            this.btnAssociation.TabIndex = 22;
            this.btnAssociation.Text = "Adhesion";
            this.btnAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssociation.UseVisualStyleBackColor = false;
            this.btnAssociation.Click += new System.EventHandler(this.btnAssociation_Click);
            // 
            // btnCategorieEngin
            // 
            this.btnCategorieEngin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategorieEngin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCategorieEngin.FlatAppearance.BorderSize = 0;
            this.btnCategorieEngin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorieEngin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorieEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCategorieEngin.Image = global::ICTaximen.Properties.Resources.ville_32;
            this.btnCategorieEngin.Location = new System.Drawing.Point(401, 204);
            this.btnCategorieEngin.Name = "btnCategorieEngin";
            this.btnCategorieEngin.Size = new System.Drawing.Size(174, 129);
            this.btnCategorieEngin.TabIndex = 21;
            this.btnCategorieEngin.Text = "Categorie Engin";
            this.btnCategorieEngin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorieEngin.UseVisualStyleBackColor = false;
            this.btnCategorieEngin.Click += new System.EventHandler(this.btnCategorieEngin_Click);
            // 
            // btnParameter
            // 
            this.btnParameter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnParameter.FlatAppearance.BorderSize = 0;
            this.btnParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnParameter.Image = global::ICTaximen.Properties.Resources.Province_32;
            this.btnParameter.Location = new System.Drawing.Point(318, 344);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(123, 109);
            this.btnParameter.TabIndex = 20;
            this.btnParameter.Text = "Parametre";
            this.btnParameter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnParameter.UseVisualStyleBackColor = false;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(329, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 20);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Settigs";
            // 
            // btnFonction
            // 
            this.btnFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFonction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnFonction.FlatAppearance.BorderSize = 0;
            this.btnFonction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFonction.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFonction.Image = global::ICTaximen.Properties.Resources.commune_32;
            this.btnFonction.Location = new System.Drawing.Point(401, 62);
            this.btnFonction.Name = "btnFonction";
            this.btnFonction.Size = new System.Drawing.Size(174, 129);
            this.btnFonction.TabIndex = 2;
            this.btnFonction.Text = "  Fonction";
            this.btnFonction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFonction.UseVisualStyleBackColor = false;
            this.btnFonction.Click += new System.EventHandler(this.btnFonction_Click);
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUtilisateur.Image = global::ICTaximen.Properties.Resources.ville_32;
            this.btnUtilisateur.Location = new System.Drawing.Point(230, 203);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(162, 129);
            this.btnUtilisateur.TabIndex = 2;
            this.btnUtilisateur.Text = "  Utilisateur";
            this.btnUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtilisateur.UseVisualStyleBackColor = false;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(762, 519);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFonction;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnAssociation;
        private System.Windows.Forms.Button btnCategorieEngin;
        private System.Windows.Forms.Button btnAssoociation;
        private System.Windows.Forms.Button btnAttribuer;
        private System.Windows.Forms.Button btnReport;
    }
}
