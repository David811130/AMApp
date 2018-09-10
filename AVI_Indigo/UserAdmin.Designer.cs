namespace AVI_Indigo
{
    partial class UserAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdmin));
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserNameCreate = new System.Windows.Forms.TextBox();
            this.tbPWCreate = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.tbPWCreateRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authentication1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticationDataSet = new AVI_Indigo.AuthenticationDataSet();
            this.authentication1TableAdapter = new AVI_Indigo.AuthenticationDataSetTableAdapters.Authentication1TableAdapter();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authentication1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(482, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Administration";
            // 
            // tbUserNameCreate
            // 
            this.tbUserNameCreate.Location = new System.Drawing.Point(216, 116);
            this.tbUserNameCreate.Name = "tbUserNameCreate";
            this.tbUserNameCreate.Size = new System.Drawing.Size(242, 20);
            this.tbUserNameCreate.TabIndex = 0;
            // 
            // tbPWCreate
            // 
            this.tbPWCreate.Location = new System.Drawing.Point(216, 173);
            this.tbPWCreate.Name = "tbPWCreate";
            this.tbPWCreate.PasswordChar = '*';
            this.tbPWCreate.Size = new System.Drawing.Size(242, 20);
            this.tbPWCreate.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(125, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 19);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPW.Location = new System.Drawing.Point(125, 173);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(71, 19);
            this.labelPW.TabIndex = 12;
            this.labelPW.Text = "Password";
            this.labelPW.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbPWCreateRe
            // 
            this.tbPWCreateRe.Location = new System.Drawing.Point(216, 211);
            this.tbPWCreateRe.Name = "tbPWCreateRe";
            this.tbPWCreateRe.PasswordChar = '*';
            this.tbPWCreateRe.Size = new System.Drawing.Size(242, 20);
            this.tbPWCreateRe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Re-Type Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(129, 265);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(329, 46);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authentication1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(709, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 424);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 350;
            // 
            // authentication1BindingSource
            // 
            this.authentication1BindingSource.DataMember = "Authentication1";
            this.authentication1BindingSource.DataSource = this.authenticationDataSet;
            // 
            // authenticationDataSet
            // 
            this.authenticationDataSet.DataSetName = "AuthenticationDataSet";
            this.authenticationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authentication1TableAdapter
            // 
            this.authentication1TableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(709, 575);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(423, 46);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.Location = new System.Drawing.Point(129, 575);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(280, 46);
            this.BtnMainMenu.TabIndex = 5;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.tbPWCreateRe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserNameCreate);
            this.Controls.Add(this.tbPWCreate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Administration";
            this.Load += new System.EventHandler(this.UserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authentication1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserNameCreate;
        private System.Windows.Forms.TextBox tbPWCreate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox tbPWCreateRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AuthenticationDataSet authenticationDataSet;
        private System.Windows.Forms.BindingSource authentication1BindingSource;
        private AuthenticationDataSetTableAdapters.Authentication1TableAdapter authentication1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button BtnMainMenu;
    }
}