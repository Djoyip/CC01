namespace CC01.WinForms
{
    partial class Ecole
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
            this.lblNom = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtBp = new System.Windows.Forms.TextBox();
            this.lblBp = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.picturePhoto = new System.Windows.Forms.PictureBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 149);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.ForeColor = System.Drawing.Color.Blue;
            this.btnCreer.Location = new System.Drawing.Point(247, 376);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(105, 41);
            this.btnCreer.TabIndex = 1;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(245, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Noms";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adresse";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BP/Box";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ContactEcole";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "EmailEcole";
            this.Column6.Name = "Column6";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(16, 172);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(208, 26);
            this.txtNom.TabIndex = 0;
            // 
            // txtBp
            // 
            this.txtBp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBp.Location = new System.Drawing.Point(16, 285);
            this.txtBp.Name = "txtBp";
            this.txtBp.Size = new System.Drawing.Size(208, 26);
            this.txtBp.TabIndex = 2;
            // 
            // lblBp
            // 
            this.lblBp.AutoSize = true;
            this.lblBp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBp.Location = new System.Drawing.Point(12, 262);
            this.lblBp.Name = "lblBp";
            this.lblBp.Size = new System.Drawing.Size(61, 20);
            this.lblBp.TabIndex = 8;
            this.lblBp.Text = "BP/Box";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(16, 391);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 368);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EmailEcole";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(16, 233);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(208, 26);
            this.txtAdresse.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.Green;
            this.btnImprimer.Location = new System.Drawing.Point(656, 376);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 41);
            this.btnImprimer.TabIndex = 11;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Purple;
            this.btnModifier.Location = new System.Drawing.Point(393, 376);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(102, 41);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(349, 37);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(395, 26);
            this.txtRecherche.TabIndex = 5;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(256, 37);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(87, 20);
            this.lblRecherche.TabIndex = 11;
            this.lblRecherche.Text = "Recherche";
            // 
            // picturePhoto
            // 
            this.picturePhoto.Location = new System.Drawing.Point(16, 32);
            this.picturePhoto.Name = "picturePhoto";
            this.picturePhoto.Size = new System.Drawing.Size(178, 103);
            this.picturePhoto.TabIndex = 15;
            this.picturePhoto.TabStop = false;
            this.picturePhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(12, 210);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(16, 337);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(208, 26);
            this.txtContact.TabIndex = 3;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(12, 314);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(105, 20);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "ContactEcole";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(533, 376);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 41);
            this.btnSupprimer.TabIndex = 19;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(12, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(45, 20);
            this.lblLogo.TabIndex = 20;
            this.lblLogo.Text = "Logo";
            // 
            // Ecole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(765, 437);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.picturePhoto);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBp);
            this.Controls.Add(this.lblBp);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.lblNom);
            this.Name = "Ecole";
            this.Text = "Ecole";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtBp;
        private System.Windows.Forms.Label lblBp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.PictureBox picturePhoto;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblLogo;
    }
}