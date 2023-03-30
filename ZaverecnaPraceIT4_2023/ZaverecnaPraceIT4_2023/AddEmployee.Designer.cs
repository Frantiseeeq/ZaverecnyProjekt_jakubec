namespace ZaverecnaPraceIT4_2023
{
    partial class AddEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUser);
            this.groupBox1.Controls.Add(this.rbtnAdmin);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(259, 303);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(48, 19);
            this.rbtnUser.TabIndex = 13;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(159, 303);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(61, 19);
            this.rbtnAdmin.TabIndex = 12;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(159, 174);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(257, 23);
            this.TxtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(159, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(503, 299);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 91);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(531, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 640);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 91);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(49, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 91);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label1;
        private Button btnSave;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnUpdate;
        private RadioButton rbtnUser;
        private RadioButton rbtnAdmin;
    }
}