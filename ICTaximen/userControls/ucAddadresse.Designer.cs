﻿namespace ICTaximen.userControls
{
    partial class ucAddadresse
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.lblChoose = new System.Windows.Forms.Label();
            this.cmbChoose = new System.Windows.Forms.ComboBox();
            this.pbRef = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.lblLib = new System.Windows.Forms.Label();
            this.txtlibelle = new System.Windows.Forms.TextBox();
            this.pbLibelle = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlContainner.SuspendLayout();
            this.pnlChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRef)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.pnlPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibelle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainner
            // 
            this.pnlContainner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlContainner.Controls.Add(this.lblTitle);
            this.pnlContainner.Controls.Add(this.pnlChoose);
            this.pnlContainner.Controls.Add(this.pnlOption);
            this.pnlContainner.Controls.Add(this.pnlPwd);
            this.pnlContainner.Location = new System.Drawing.Point(4, 4);
            this.pnlContainner.Name = "pnlContainner";
            this.pnlContainner.Size = new System.Drawing.Size(754, 510);
            this.pnlContainner.TabIndex = 3;
            this.pnlContainner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainner_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(328, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Text Title";
            // 
            // pnlChoose
            // 
            this.pnlChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlChoose.Controls.Add(this.lblId);
            this.pnlChoose.Controls.Add(this.lblChoose);
            this.pnlChoose.Controls.Add(this.cmbChoose);
            this.pnlChoose.Controls.Add(this.pbRef);
            this.pnlChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChoose.Location = new System.Drawing.Point(122, 177);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(508, 77);
            this.pnlChoose.TabIndex = 7;
            // 
            // lblChoose
            // 
            this.lblChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoose.AutoSize = true;
            this.lblChoose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblChoose.Location = new System.Drawing.Point(11, 8);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(82, 20);
            this.lblChoose.TabIndex = 9;
            this.lblChoose.Text = "Text Title";
            // 
            // cmbChoose
            // 
            this.cmbChoose.AllowDrop = true;
            this.cmbChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbChoose.FormattingEnabled = true;
            this.cmbChoose.Location = new System.Drawing.Point(43, 36);
            this.cmbChoose.Name = "cmbChoose";
            this.cmbChoose.Size = new System.Drawing.Size(455, 32);
            this.cmbChoose.TabIndex = 1;
            this.cmbChoose.SelectedIndexChanged += new System.EventHandler(this.cmbChoose_SelectedIndexChanged);
            this.cmbChoose.TabIndexChanged += new System.EventHandler(this.cmbChoose_TabIndexChanged);
            this.cmbChoose.MouseHover += new System.EventHandler(this.cmbChoose_MouseHover);
            // 
            // pbRef
            // 
            this.pbRef.Image = global::ICTaximen.Properties.Resources.Lock_2_40px;
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
            // pnlPwd
            // 
            this.pnlPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlPwd.Controls.Add(this.lblLib);
            this.pnlPwd.Controls.Add(this.txtlibelle);
            this.pnlPwd.Controls.Add(this.pbLibelle);
            this.pnlPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPwd.Location = new System.Drawing.Point(122, 94);
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
            this.lblLib.Size = new System.Drawing.Size(61, 20);
            this.lblLib.TabIndex = 10;
            this.lblLib.Text = "Libelle";
            // 
            // txtlibelle
            // 
            this.txtlibelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtlibelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlibelle.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtlibelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtlibelle.Location = new System.Drawing.Point(45, 41);
            this.txtlibelle.Name = "txtlibelle";
            this.txtlibelle.Size = new System.Drawing.Size(458, 23);
            this.txtlibelle.TabIndex = 2;
            this.txtlibelle.Tag = "";
            // 
            // pbLibelle
            // 
            this.pbLibelle.Image = global::ICTaximen.Properties.Resources.Lock_2_40px;
            this.pbLibelle.Location = new System.Drawing.Point(15, 40);
            this.pbLibelle.Name = "pbLibelle";
            this.pbLibelle.Size = new System.Drawing.Size(24, 24);
            this.pbLibelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibelle.TabIndex = 0;
            this.pbLibelle.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblId.Location = new System.Drawing.Point(485, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 22);
            this.lblId.TabIndex = 10;
            // 
            // ucAddadresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainner);
            this.Name = "ucAddadresse";
            this.Size = new System.Drawing.Size(762, 519);
            this.Load += new System.EventHandler(this.ucAddadresse_Load);
            this.pnlContainner.ResumeLayout(false);
            this.pnlContainner.PerformLayout();
            this.pnlChoose.ResumeLayout(false);
            this.pnlChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRef)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlPwd;
        private System.Windows.Forms.PictureBox pbLibelle;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.PictureBox pbRef;
        private System.Windows.Forms.TextBox txtlibelle;
        private System.Windows.Forms.ComboBox cmbChoose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.Label lblId;
    }
}
