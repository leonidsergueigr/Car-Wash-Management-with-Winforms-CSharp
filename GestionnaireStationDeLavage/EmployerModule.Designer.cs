namespace GestionnaireStationDeLavage
{
    partial class EmployerModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtAddress = new Bunifu.Framework.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new Bunifu.Framework.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Eid = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(97, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "AJOUT DES EMPLOYES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom Complets:";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtName.Location = new System.Drawing.Point(304, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(517, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date de naissance:";
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.CheckedState.Parent = this.txtBirthDay;
            this.txtBirthDay.FillColor = System.Drawing.Color.White;
            this.txtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthDay.HoverState.Parent = this.txtBirthDay;
            this.txtBirthDay.Location = new System.Drawing.Point(304, 237);
            this.txtBirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtBirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.ShadowDecoration.Parent = this.txtBirthDay;
            this.txtBirthDay.Size = new System.Drawing.Size(144, 26);
            this.txtBirthDay.TabIndex = 5;
            this.txtBirthDay.Value = new System.DateTime(2024, 9, 15, 6, 44, 3, 780);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPhone.Location = new System.Drawing.Point(630, 237);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(191, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAddress.Location = new System.Drawing.Point(304, 293);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(517, 66);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.bunifuCustomTextbox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresse:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rôle:";
            // 
            // cbRole
            // 
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Gérant",
            "Superviseur",
            "Caissier",
            "Ouvrier"});
            this.cbRole.Location = new System.Drawing.Point(304, 388);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(517, 28);
            this.cbRole.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salaire:";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSalary.Location = new System.Drawing.Point(304, 446);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(191, 26);
            this.txtSalary.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Genre:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Location = new System.Drawing.Point(629, 450);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(83, 24);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Homme";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(741, 450);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "Femme";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Eid
            // 
            this.Eid.AutoSize = true;
            this.Eid.Location = new System.Drawing.Point(97, 539);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(30, 20);
            this.Eid.TabIndex = 20;
            this.Eid.Text = "Eid";
            this.Eid.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GestionnaireStationDeLavage.Properties.Resources.close_window_20px;
            this.btnExit.Location = new System.Drawing.Point(795, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 37);
            this.btnExit.TabIndex = 21;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::GestionnaireStationDeLavage.Properties.Resources.cancel_45px;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(677, 525);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 49);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GestionnaireStationDeLavage.Properties.Resources.update_left_rotation_45px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(454, 525);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Mis à Jour";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepPink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::GestionnaireStationDeLavage.Properties.Resources.save_45px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(230, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 49);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // EmployerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 641);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Eid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployerModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployerModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.BunifuCustomTextbox txtName;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtBirthDay;
        public System.Windows.Forms.Label label4;
        public Bunifu.Framework.BunifuCustomTextbox txtPhone;
        public Bunifu.Framework.BunifuCustomTextbox txtAddress;
        public System.Windows.Forms.ComboBox cbRole;
        public Bunifu.Framework.BunifuCustomTextbox txtSalary;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RadioButton rbMale;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Eid;
        private System.Windows.Forms.Button btnExit;
    }
}