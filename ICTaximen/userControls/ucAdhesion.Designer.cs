namespace ICTaximen.userControls
{
    partial class ucAdhesion
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
            this.lblChoosePersonne = new System.Windows.Forms.Label();
            this.cmbTaximen = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.lblChooseAdresse = new System.Windows.Forms.Label();
            this.cmbAssociation = new System.Windows.Forms.ComboBox();
            this.pbRef = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTaximan = new System.Windows.Forms.Label();
            this.txtAssociation = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
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
            this.pnlContainner.Controls.Add(this.txtId);
            this.pnlContainner.Controls.Add(this.panel1);
            this.pnlContainner.Controls.Add(this.lblTitle);
            this.pnlContainner.Controls.Add(this.pnlChoose);
            this.pnlContainner.Controls.Add(this.pnlOption);
            this.pnlContainner.Location = new System.Drawing.Point(4, 4);
            this.pnlContainner.Name = "pnlContainner";
            this.pnlContainner.Size = new System.Drawing.Size(754, 510);
            this.pnlContainner.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtTaximan);
            this.panel1.Controls.Add(this.lblChoosePersonne);
            this.panel1.Controls.Add(this.cmbTaximen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(122, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 77);
            this.panel1.TabIndex = 9;
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
            this.lblChoosePersonne.Size = new System.Drawing.Size(153, 20);
            this.lblChoosePersonne.TabIndex = 9;
            this.lblChoosePersonne.Text = "Chercher Taximan";
            // 
            // cmbTaximen
            // 
            this.cmbTaximen.AllowDrop = true;
            this.cmbTaximen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbTaximen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaximen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTaximen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbTaximen.FormattingEnabled = true;
            this.cmbTaximen.Location = new System.Drawing.Point(43, 36);
            this.cmbTaximen.Name = "cmbTaximen";
            this.cmbTaximen.Size = new System.Drawing.Size(455, 32);
            this.cmbTaximen.TabIndex = 1;
            this.cmbTaximen.SelectedIndexChanged += new System.EventHandler(this.cmbTaximen_SelectedIndexChanged);
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
            this.lblTitle.Location = new System.Drawing.Point(341, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Adhesion";
            // 
            // pnlChoose
            // 
            this.pnlChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlChoose.Controls.Add(this.txtAssociation);
            this.pnlChoose.Controls.Add(this.lblChooseAdresse);
            this.pnlChoose.Controls.Add(this.cmbAssociation);
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
            this.lblChooseAdresse.Size = new System.Drawing.Size(235, 20);
            this.lblChooseAdresse.TabIndex = 9;
            this.lblChooseAdresse.Text = "Selectionner ASSOCIATION";
            // 
            // cmbAssociation
            // 
            this.cmbAssociation.AllowDrop = true;
            this.cmbAssociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbAssociation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbAssociation.FormattingEnabled = true;
            this.cmbAssociation.Location = new System.Drawing.Point(43, 36);
            this.cmbAssociation.Name = "cmbAssociation";
            this.cmbAssociation.Size = new System.Drawing.Size(455, 32);
            this.cmbAssociation.TabIndex = 1;
            this.cmbAssociation.SelectedIndexChanged += new System.EventHandler(this.cmbAssociation_SelectedIndexChanged);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTaximan
            // 
            this.txtTaximan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaximan.AutoSize = true;
            this.txtTaximan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTaximan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTaximan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtTaximan.Location = new System.Drawing.Point(477, 8);
            this.txtTaximan.Name = "txtTaximan";
            this.txtTaximan.Size = new System.Drawing.Size(0, 20);
            this.txtTaximan.TabIndex = 11;
            this.txtTaximan.TextChanged += new System.EventHandler(this.txtTaximan_TextChanged);
            // 
            // txtAssociation
            // 
            this.txtAssociation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssociation.AutoSize = true;
            this.txtAssociation.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAssociation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtAssociation.Location = new System.Drawing.Point(477, 8);
            this.txtAssociation.Name = "txtAssociation";
            this.txtAssociation.Size = new System.Drawing.Size(0, 20);
            this.txtAssociation.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.AutoSize = true;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtId.Location = new System.Drawing.Point(599, 270);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 20);
            this.txtId.TabIndex = 11;
            // 
            // ucAdhesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainner);
            this.Name = "ucAdhesion";
            this.Size = new System.Drawing.Size(762, 519);
            this.Load += new System.EventHandler(this.ucAdhesion_Load);
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
        private System.Windows.Forms.ComboBox cmbTaximen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Label lblChooseAdresse;
        private System.Windows.Forms.ComboBox cmbAssociation;
        private System.Windows.Forms.PictureBox pbRef;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtTaximan;
        private System.Windows.Forms.Label txtAssociation;
    }
}
