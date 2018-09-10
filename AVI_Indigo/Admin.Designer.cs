namespace AVI_Indigo
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.indigoBanner = new System.Windows.Forms.PictureBox();
            this.btnUserAdmin = new System.Windows.Forms.Button();
            this.btnAssetAdmin = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indigoBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // indigoBanner
            // 
            this.indigoBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("indigoBanner.BackgroundImage")));
            this.indigoBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.indigoBanner.Location = new System.Drawing.Point(409, 53);
            this.indigoBanner.Name = "indigoBanner";
            this.indigoBanner.Size = new System.Drawing.Size(445, 122);
            this.indigoBanner.TabIndex = 28;
            this.indigoBanner.TabStop = false;
            // 
            // btnUserAdmin
            // 
            this.btnUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdmin.Location = new System.Drawing.Point(410, 274);
            this.btnUserAdmin.Name = "btnUserAdmin";
            this.btnUserAdmin.Size = new System.Drawing.Size(445, 46);
            this.btnUserAdmin.TabIndex = 0;
            this.btnUserAdmin.Text = "User Administration";
            this.btnUserAdmin.UseVisualStyleBackColor = true;
            this.btnUserAdmin.Click += new System.EventHandler(this.btnUserAdmin_Click);
            // 
            // btnAssetAdmin
            // 
            this.btnAssetAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssetAdmin.Location = new System.Drawing.Point(410, 359);
            this.btnAssetAdmin.Name = "btnAssetAdmin";
            this.btnAssetAdmin.Size = new System.Drawing.Size(445, 46);
            this.btnAssetAdmin.TabIndex = 1;
            this.btnAssetAdmin.Text = "Asset Administration";
            this.btnAssetAdmin.UseVisualStyleBackColor = true;
            this.btnAssetAdmin.Click += new System.EventHandler(this.btnAssetAdmin_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(958, 548);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(280, 46);
            this.BtnLogOut.TabIndex = 3;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(31, 548);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(280, 46);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Main Menu";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUserAdmin);
            this.Controls.Add(this.btnAssetAdmin);
            this.Controls.Add(this.indigoBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indigoBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox indigoBanner;
        private System.Windows.Forms.Button btnUserAdmin;
        private System.Windows.Forms.Button btnAssetAdmin;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button btnAdmin;
    }
}