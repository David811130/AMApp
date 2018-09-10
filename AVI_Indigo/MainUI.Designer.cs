namespace AVI_Indigo
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.indigoBanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tbAssetNumber = new System.Windows.Forms.TextBox();
            this.btnAssetView = new System.Windows.Forms.Button();
            this.btnTransferAsset = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.tbCurrentLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchAsset = new System.Windows.Forms.Button();
            this.tbMoveTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.indigoBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // indigoBanner
            // 
            this.indigoBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("indigoBanner.BackgroundImage")));
            this.indigoBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.indigoBanner.Location = new System.Drawing.Point(420, 12);
            this.indigoBanner.Name = "indigoBanner";
            this.indigoBanner.Size = new System.Drawing.Size(405, 122);
            this.indigoBanner.TabIndex = 2;
            this.indigoBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Move Asset To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(417, 216);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 15);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Asset Number";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbAssetNumber
            // 
            this.tbAssetNumber.Location = new System.Drawing.Point(583, 211);
            this.tbAssetNumber.Name = "tbAssetNumber";
            this.tbAssetNumber.Size = new System.Drawing.Size(242, 20);
            this.tbAssetNumber.TabIndex = 0;
            // 
            // btnAssetView
            // 
            this.btnAssetView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssetView.Location = new System.Drawing.Point(420, 466);
            this.btnAssetView.Name = "btnAssetView";
            this.btnAssetView.Size = new System.Drawing.Size(405, 46);
            this.btnAssetView.TabIndex = 5;
            this.btnAssetView.Text = "View Assets / Generate Reports";
            this.btnAssetView.UseVisualStyleBackColor = true;
            this.btnAssetView.Click += new System.EventHandler(this.btnAssetView_Click);
            // 
            // btnTransferAsset
            // 
            this.btnTransferAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferAsset.Location = new System.Drawing.Point(420, 313);
            this.btnTransferAsset.Name = "btnTransferAsset";
            this.btnTransferAsset.Size = new System.Drawing.Size(405, 46);
            this.btnTransferAsset.TabIndex = 4;
            this.btnTransferAsset.Text = "Transfer Asset";
            this.btnTransferAsset.UseVisualStyleBackColor = true;
            this.btnTransferAsset.Click += new System.EventHandler(this.btnTransferAsset_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(24, 564);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(280, 46);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Administrators";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(951, 564);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(280, 46);
            this.BtnLogOut.TabIndex = 8;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // tbCurrentLocation
            // 
            this.tbCurrentLocation.Location = new System.Drawing.Point(583, 237);
            this.tbCurrentLocation.Name = "tbCurrentLocation";
            this.tbCurrentLocation.Size = new System.Drawing.Size(242, 20);
            this.tbCurrentLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Current Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSearchAsset
            // 
            this.btnSearchAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAsset.Location = new System.Drawing.Point(868, 208);
            this.btnSearchAsset.Name = "btnSearchAsset";
            this.btnSearchAsset.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAsset.TabIndex = 1;
            this.btnSearchAsset.Text = "Search Asset Number";
            this.btnSearchAsset.UseVisualStyleBackColor = true;
            this.btnSearchAsset.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMoveTo
            // 
            this.tbMoveTo.Location = new System.Drawing.Point(583, 274);
            this.tbMoveTo.Name = "tbMoveTo";
            this.tbMoveTo.Size = new System.Drawing.Size(242, 20);
            this.tbMoveTo.TabIndex = 3;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.tbMoveTo);
            this.Controls.Add(this.btnSearchAsset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurrentLocation);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAssetView);
            this.Controls.Add(this.btnTransferAsset);
            this.Controls.Add(this.tbAssetNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.indigoBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Management Dashboard";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indigoBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox indigoBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox tbAssetNumber;
        private System.Windows.Forms.Button btnAssetView;
        private System.Windows.Forms.Button btnTransferAsset;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.TextBox tbCurrentLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchAsset;
        private System.Windows.Forms.TextBox tbMoveTo;
    }
}