namespace ICTaximen.userControls
{
    partial class ucCategorieEngin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.lblLib = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.pbLibelle = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvEngin = new System.Windows.Forms.DataGridView();
            this.pnlContainner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlOption.SuspendLayout();
            this.pnlPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainner
            // 
            this.pnlContainner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlContainner.Controls.Add(this.txtid);
            this.pnlContainner.Controls.Add(this.panel1);
            this.pnlContainner.Controls.Add(this.lblTitle);
            this.pnlContainner.Controls.Add(this.pnlOption);
            this.pnlContainner.Controls.Add(this.pnlPwd);
            this.pnlContainner.Location = new System.Drawing.Point(4, 4);
            this.pnlContainner.Name = "pnlContainner";
            this.pnlContainner.Size = new System.Drawing.Size(754, 510);
            this.pnlContainner.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.dgvEngin);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(289, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 278);
            this.panel1.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(306, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Ajout Categorie Engin";
            // 
            // pnlOption
            // 
            this.pnlOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlOption.Controls.Add(this.btnSave);
            this.pnlOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOption.Location = new System.Drawing.Point(112, 190);
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
            this.btnSave.Location = new System.Drawing.Point(7, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 90);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlPwd
            // 
            this.pnlPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlPwd.Controls.Add(this.lblLib);
            this.pnlPwd.Controls.Add(this.txtCategorie);
            this.pnlPwd.Controls.Add(this.pbLibelle);
            this.pnlPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPwd.Location = new System.Drawing.Point(112, 96);
            this.pnlPwd.Name = "pnlPwd";
            this.pnlPwd.Size = new System.Drawing.Size(508, 77);
            this.pnlPwd.TabIndex = 4;
            // 
            // lblLib
            // 
            this.lblLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLib.AutoSize = true;
            this.lblLib.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblLib.Location = new System.Drawing.Point(11, 12);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(87, 20);
            this.lblLib.TabIndex = 10;
            this.lblLib.Text = "Categorie";
            // 
            // txtCategorie
            // 
            this.txtCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategorie.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCategorie.Location = new System.Drawing.Point(45, 41);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(458, 23);
            this.txtCategorie.TabIndex = 2;
            this.txtCategorie.Tag = "";
            // 
            // pbLibelle
            // 
            this.pbLibelle.Image = global::ICTaximen.Properties.Resources.fonction_16;
            this.pbLibelle.Location = new System.Drawing.Point(15, 40);
            this.pbLibelle.Name = "pbLibelle";
            this.pbLibelle.Size = new System.Drawing.Size(24, 24);
            this.pbLibelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibelle.TabIndex = 0;
            this.pbLibelle.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.txtid.Location = new System.Drawing.Point(212, 297);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(71, 23);
            this.txtid.TabIndex = 13;
            this.txtid.Tag = "";
            // 
            // dgvEngin
            // 
            this.dgvEngin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvEngin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvEngin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEngin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEngin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEngin.ColumnHeadersHeight = 35;
            this.dgvEngin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEngin.EnableHeadersVisualStyles = false;
            this.dgvEngin.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEngin.Location = new System.Drawing.Point(3, 6);
            this.dgvEngin.Name = "dgvEngin";
            this.dgvEngin.ReadOnly = true;
            this.dgvEngin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEngin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEngin.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEngin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEngin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEngin.Size = new System.Drawing.Size(320, 269);
            this.dgvEngin.TabIndex = 15;
            this.dgvEngin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEngin_CellClick);
            // 
            // ucCategorieEngin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainner);
            this.Name = "ucCategorieEngin";
            this.Size = new System.Drawing.Size(762, 519);
            this.Load += new System.EventHandler(this.ucCategorieEngin_Load);
            this.pnlContainner.ResumeLayout(false);
            this.pnlContainner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlOption.ResumeLayout(false);
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlPwd;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.PictureBox pbLibelle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvEngin;
    }
}
