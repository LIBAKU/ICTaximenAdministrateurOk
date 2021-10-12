namespace ICTaximen.userControls
{
    partial class ucAttributionAdresseForm
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
            this.pnlContainner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbTaximan = new System.Windows.Forms.RadioButton();
            this.rdbAgent = new System.Windows.Forms.RadioButton();
            this.lblChoosePersonne = new System.Windows.Forms.Label();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.lblChooseAdresse = new System.Windows.Forms.Label();
            this.cmbAddresse = new System.Windows.Forms.ComboBox();
            this.pbRef = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbProprietaire = new System.Windows.Forms.RadioButton();
            this.pnlContainner.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRef)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainner
            // 
            this.pnlContainner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlContainner.Controls.Add(this.panel1);
            this.pnlContainner.Controls.Add(this.lblTitle);
            this.pnlContainner.Controls.Add(this.pnlChoose);
            this.pnlContainner.Controls.Add(this.pnlOption);
            this.pnlContainner.Location = new System.Drawing.Point(4, 4);
            this.pnlContainner.Name = "pnlContainner";
            this.pnlContainner.Size = new System.Drawing.Size(754, 510);
            this.pnlContainner.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.rdbProprietaire);
            this.panel1.Controls.Add(this.rdbTaximan);
            this.panel1.Controls.Add(this.rdbAgent);
            this.panel1.Controls.Add(this.lblChoosePersonne);
            this.panel1.Controls.Add(this.cmbPersonne);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(122, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 77);
            this.panel1.TabIndex = 9;
            // 
            // rdbTaximan
            // 
            this.rdbTaximan.AutoSize = true;
            this.rdbTaximan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rdbTaximan.Location = new System.Drawing.Point(349, 8);
            this.rdbTaximan.Name = "rdbTaximan";
            this.rdbTaximan.Size = new System.Drawing.Size(65, 17);
            this.rdbTaximan.TabIndex = 10;
            this.rdbTaximan.TabStop = true;
            this.rdbTaximan.Text = "Taximan";
            this.rdbTaximan.UseVisualStyleBackColor = true;
            // 
            // rdbAgent
            // 
            this.rdbAgent.AutoSize = true;
            this.rdbAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rdbAgent.Location = new System.Drawing.Point(284, 8);
            this.rdbAgent.Name = "rdbAgent";
            this.rdbAgent.Size = new System.Drawing.Size(53, 17);
            this.rdbAgent.TabIndex = 11;
            this.rdbAgent.TabStop = true;
            this.rdbAgent.Text = "Agent";
            this.rdbAgent.UseVisualStyleBackColor = true;
            // 
            // lblChoosePersonne
            // 
            this.lblChoosePersonne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoosePersonne.AutoSize = true;
            this.lblChoosePersonne.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChoosePersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblChoosePersonne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblChoosePersonne.Location = new System.Drawing.Point(11, 8);
            this.lblChoosePersonne.Name = "lblChoosePersonne";
            this.lblChoosePersonne.Size = new System.Drawing.Size(163, 20);
            this.lblChoosePersonne.TabIndex = 9;
            this.lblChoosePersonne.Text = "Chercher Personne";
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.AllowDrop = true;
            this.cmbPersonne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbPersonne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(43, 36);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(455, 32);
            this.cmbPersonne.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICTaximen.Properties.Resources.Name1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(284, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Attribution addresse";
            // 
            // pnlChoose
            // 
            this.pnlChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlChoose.Controls.Add(this.lblChooseAdresse);
            this.pnlChoose.Controls.Add(this.cmbAddresse);
            this.pnlChoose.Controls.Add(this.pbRef);
            this.pnlChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChoose.Location = new System.Drawing.Point(122, 177);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(508, 77);
            this.pnlChoose.TabIndex = 7;
            // 
            // lblChooseAdresse
            // 
            this.lblChooseAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChooseAdresse.AutoSize = true;
            this.lblChooseAdresse.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChooseAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblChooseAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblChooseAdresse.Location = new System.Drawing.Point(11, 8);
            this.lblChooseAdresse.Name = "lblChooseAdresse";
            this.lblChooseAdresse.Size = new System.Drawing.Size(191, 20);
            this.lblChooseAdresse.TabIndex = 9;
            this.lblChooseAdresse.Text = "Selectionner Addresse";
            // 
            // cmbAddresse
            // 
            this.cmbAddresse.AllowDrop = true;
            this.cmbAddresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbAddresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbAddresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbAddresse.FormattingEnabled = true;
            this.cmbAddresse.Location = new System.Drawing.Point(43, 36);
            this.cmbAddresse.Name = "cmbAddresse";
            this.cmbAddresse.Size = new System.Drawing.Size(455, 32);
            this.cmbAddresse.TabIndex = 1;
            // 
            // pbRef
            // 
            this.pbRef.Image = global::ICTaximen.Properties.Resources.Address_16;
            this.pbRef.Location = new System.Drawing.Point(13, 39);
            this.pbRef.Name = "pbRef";
            this.pbRef.Size = new System.Drawing.Size(24, 24);
            this.pbRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRef.TabIndex = 0;
            this.pbRef.TabStop = false;
            // 
            // pnlOption
            // 
            this.pnlOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlOption.Controls.Add(this.btnSave);
            this.pnlOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOption.Location = new System.Drawing.Point(292, 270);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(171, 101);
            this.pnlOption.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Image = global::ICTaximen.Properties.Resources.save_48;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 90);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // rdbProprietaire
            // 
            this.rdbProprietaire.AutoSize = true;
            this.rdbProprietaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.rdbProprietaire.Location = new System.Drawing.Point(426, 8);
            this.rdbProprietaire.Name = "rdbProprietaire";
            this.rdbProprietaire.Size = new System.Drawing.Size(78, 17);
            this.rdbProprietaire.TabIndex = 10;
            this.rdbProprietaire.TabStop = true;
            this.rdbProprietaire.Text = "Proprietaire";
            this.rdbProprietaire.UseVisualStyleBackColor = true;
            // 
            // ucAttributionAdresseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainner);
            this.Name = "ucAttributionAdresseForm";
            this.Size = new System.Drawing.Size(762, 519);
            this.pnlContainner.ResumeLayout(false);
            this.pnlContainner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChoose.ResumeLayout(false);
            this.pnlChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRef)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChoosePersonne;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Label lblChooseAdresse;
        private System.Windows.Forms.ComboBox cmbAddresse;
        private System.Windows.Forms.PictureBox pbRef;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbTaximan;
        private System.Windows.Forms.RadioButton rdbAgent;
        private System.Windows.Forms.RadioButton rdbProprietaire;
    }
}
