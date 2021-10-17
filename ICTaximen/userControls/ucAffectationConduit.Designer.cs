namespace ICTaximen.userControls
{
    partial class ucAffectationConduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainner = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtIdmoto = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvAffectationListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChoosePersonne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNummoteur = new System.Windows.Forms.Label();
            this.txtNumchasis = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.Label();
            this.txtMarque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.txtTaximan = new System.Windows.Forms.Label();
            this.lblChooseAdresse = new System.Windows.Forms.Label();
            this.cmbTaximan = new System.Windows.Forms.ComboBox();
            this.pbRef = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContainner.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffectationListe)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnlContainner.Controls.Add(this.label6);
            this.pnlContainner.Controls.Add(this.txtid);
            this.pnlContainner.Controls.Add(this.txtIdmoto);
            this.pnlContainner.Controls.Add(this.panel8);
            this.pnlContainner.Controls.Add(this.lblChoosePersonne);
            this.pnlContainner.Controls.Add(this.panel1);
            this.pnlContainner.Controls.Add(this.lblTitle);
            this.pnlContainner.Controls.Add(this.pnlChoose);
            this.pnlContainner.Controls.Add(this.pnlOption);
            this.pnlContainner.Location = new System.Drawing.Point(4, 4);
            this.pnlContainner.Name = "pnlContainner";
            this.pnlContainner.Size = new System.Drawing.Size(754, 510);
            this.pnlContainner.TabIndex = 5;
            this.pnlContainner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainner_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(197, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Utiliser";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.txtid.Location = new System.Drawing.Point(642, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(71, 23);
            this.txtid.TabIndex = 15;
            this.txtid.Tag = "";
            // 
            // txtIdmoto
            // 
            this.txtIdmoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdmoto.AutoSize = true;
            this.txtIdmoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIdmoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdmoto.ForeColor = System.Drawing.Color.White;
            this.txtIdmoto.Location = new System.Drawing.Point(200, 27);
            this.txtIdmoto.Name = "txtIdmoto";
            this.txtIdmoto.Size = new System.Drawing.Size(0, 20);
            this.txtIdmoto.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel8.Controls.Add(this.dgvAffectationListe);
            this.panel8.Controls.Add(this.label1);
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(15, 247);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(720, 249);
            this.panel8.TabIndex = 11;
            // 
            // dgvAffectationListe
            // 
            this.dgvAffectationListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvAffectationListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvAffectationListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAffectationListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAffectationListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAffectationListe.ColumnHeadersHeight = 35;
            this.dgvAffectationListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAffectationListe.EnableHeadersVisualStyles = false;
            this.dgvAffectationListe.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAffectationListe.Location = new System.Drawing.Point(6, 31);
            this.dgvAffectationListe.Name = "dgvAffectationListe";
            this.dgvAffectationListe.ReadOnly = true;
            this.dgvAffectationListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAffectationListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAffectationListe.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAffectationListe.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAffectationListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAffectationListe.Size = new System.Drawing.Size(710, 208);
            this.dgvAffectationListe.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Liste des Affectation";
            // 
            // lblChoosePersonne
            // 
            this.lblChoosePersonne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChoosePersonne.AutoSize = true;
            this.lblChoosePersonne.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChoosePersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblChoosePersonne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblChoosePersonne.Location = new System.Drawing.Point(39, 27);
            this.lblChoosePersonne.Name = "lblChoosePersonne";
            this.lblChoosePersonne.Size = new System.Drawing.Size(155, 20);
            this.lblChoosePersonne.TabIndex = 9;
            this.lblChoosePersonne.Text = "Description MOTO";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtNummoteur);
            this.panel1.Controls.Add(this.txtNumchasis);
            this.panel1.Controls.Add(this.txtCouleur);
            this.panel1.Controls.Add(this.txtMarque);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(39, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 92);
            this.panel1.TabIndex = 9;
            // 
            // txtNummoteur
            // 
            this.txtNummoteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNummoteur.AutoSize = true;
            this.txtNummoteur.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNummoteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNummoteur.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNummoteur.Location = new System.Drawing.Point(486, 59);
            this.txtNummoteur.Name = "txtNummoteur";
            this.txtNummoteur.Size = new System.Drawing.Size(0, 20);
            this.txtNummoteur.TabIndex = 18;
            // 
            // txtNumchasis
            // 
            this.txtNumchasis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumchasis.AutoSize = true;
            this.txtNumchasis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNumchasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumchasis.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNumchasis.Location = new System.Drawing.Point(485, 15);
            this.txtNumchasis.Name = "txtNumchasis";
            this.txtNumchasis.Size = new System.Drawing.Size(0, 20);
            this.txtNumchasis.TabIndex = 17;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCouleur.AutoSize = true;
            this.txtCouleur.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCouleur.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCouleur.Location = new System.Drawing.Point(123, 60);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(0, 20);
            this.txtCouleur.TabIndex = 16;
            // 
            // txtMarque
            // 
            this.txtMarque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarque.AutoSize = true;
            this.txtMarque.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtMarque.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMarque.Location = new System.Drawing.Point(122, 16);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(0, 20);
            this.txtMarque.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(329, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero Moteur :  *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(329, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero Chasis :  *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Couleur :  *";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marque :  *";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(284, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Affectaion Moto TAximan";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlChoose
            // 
            this.pnlChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlChoose.Controls.Add(this.txtTaximan);
            this.pnlChoose.Controls.Add(this.lblChooseAdresse);
            this.pnlChoose.Controls.Add(this.cmbTaximan);
            this.pnlChoose.Controls.Add(this.pbRef);
            this.pnlChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChoose.Location = new System.Drawing.Point(39, 164);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(508, 77);
            this.pnlChoose.TabIndex = 7;
            // 
            // txtTaximan
            // 
            this.txtTaximan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaximan.AutoSize = true;
            this.txtTaximan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTaximan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTaximan.ForeColor = System.Drawing.Color.White;
            this.txtTaximan.Location = new System.Drawing.Point(455, 6);
            this.txtTaximan.Name = "txtTaximan";
            this.txtTaximan.Size = new System.Drawing.Size(0, 20);
            this.txtTaximan.TabIndex = 15;
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
            this.lblChooseAdresse.Size = new System.Drawing.Size(193, 20);
            this.lblChooseAdresse.TabIndex = 9;
            this.lblChooseAdresse.Text = "Selectionner TAXIMAN";
            // 
            // cmbTaximan
            // 
            this.cmbTaximan.AllowDrop = true;
            this.cmbTaximan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbTaximan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaximan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTaximan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbTaximan.FormattingEnabled = true;
            this.cmbTaximan.Location = new System.Drawing.Point(43, 36);
            this.cmbTaximan.Name = "cmbTaximan";
            this.cmbTaximan.Size = new System.Drawing.Size(455, 32);
            this.cmbTaximan.TabIndex = 1;
            this.cmbTaximan.SelectedIndexChanged += new System.EventHandler(this.cmbTaximan_SelectedIndexChanged);
            this.cmbTaximan.MouseHover += new System.EventHandler(this.cmbTaximan_MouseHover);
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
            this.pnlOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlOption.Controls.Add(this.btnSave);
            this.pnlOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOption.Location = new System.Drawing.Point(564, 170);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(149, 71);
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
            this.btnSave.Location = new System.Drawing.Point(5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 64);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucAffectationConduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainner);
            this.Name = "ucAffectationConduit";
            this.Size = new System.Drawing.Size(762, 519);
            this.pnlContainner.ResumeLayout(false);
            this.pnlContainner.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffectationListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Label lblChooseAdresse;
        private System.Windows.Forms.ComboBox cmbTaximan;
        private System.Windows.Forms.PictureBox pbRef;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtIdmoto;
        private System.Windows.Forms.Label txtNummoteur;
        private System.Windows.Forms.Label txtNumchasis;
        private System.Windows.Forms.Label txtCouleur;
        private System.Windows.Forms.Label txtMarque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTaximan;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvAffectationListe;
        private System.Windows.Forms.Label label6;
    }
}
