namespace AVI_Indigo
{
    partial class AssetAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetAdmin));
            this.btnCreateAsset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAssetNumber = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indigoDataSet = new AVI_Indigo.IndigoDataSet();
            this.assetsTableAdapter = new AVI_Indigo.IndigoDataSetTableAdapters.AssetsTableAdapter();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indigoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAsset
            // 
            this.btnCreateAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsset.Location = new System.Drawing.Point(23, 264);
            this.btnCreateAsset.Name = "btnCreateAsset";
            this.btnCreateAsset.Size = new System.Drawing.Size(182, 46);
            this.btnCreateAsset.TabIndex = 4;
            this.btnCreateAsset.Text = "Create Asset";
            this.btnCreateAsset.UseVisualStyleBackColor = false;
            this.btnCreateAsset.Click += new System.EventHandler(this.btnCreateAsset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbAssetNumber
            // 
            this.tbAssetNumber.Location = new System.Drawing.Point(166, 75);
            this.tbAssetNumber.Name = "tbAssetNumber";
            this.tbAssetNumber.Size = new System.Drawing.Size(242, 20);
            this.tbAssetNumber.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(19, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 19);
            this.lblUsername.TabIndex = 42;
            this.lblUsername.Text = "Asset Number";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPW.Location = new System.Drawing.Point(19, 119);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(138, 19);
            this.labelPW.TabIndex = 43;
            this.labelPW.Text = "Make/Manufacturer";
            this.labelPW.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(166, 118);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(242, 20);
            this.tbMake.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(166, 160);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(242, 20);
            this.tbModel.TabIndex = 2;
            // 
            // tbSN
            // 
            this.tbSN.Location = new System.Drawing.Point(166, 205);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(242, 20);
            this.tbSN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Serial Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.Location = new System.Drawing.Point(23, 581);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(280, 46);
            this.BtnMainMenu.TabIndex = 6;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.assetNumDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialNumDataGridViewTextBoxColumn,
            this.locationCurrentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(509, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 462);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // assetNumDataGridViewTextBoxColumn
            // 
            this.assetNumDataGridViewTextBoxColumn.DataPropertyName = "AssetNum";
            this.assetNumDataGridViewTextBoxColumn.HeaderText = "AssetNum";
            this.assetNumDataGridViewTextBoxColumn.Name = "assetNumDataGridViewTextBoxColumn";
            this.assetNumDataGridViewTextBoxColumn.Width = 120;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 120;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 120;
            // 
            // serialNumDataGridViewTextBoxColumn
            // 
            this.serialNumDataGridViewTextBoxColumn.DataPropertyName = "SerialNum";
            this.serialNumDataGridViewTextBoxColumn.HeaderText = "SerialNum";
            this.serialNumDataGridViewTextBoxColumn.Name = "serialNumDataGridViewTextBoxColumn";
            this.serialNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationCurrentDataGridViewTextBoxColumn
            // 
            this.locationCurrentDataGridViewTextBoxColumn.DataPropertyName = "LocationCurrent";
            this.locationCurrentDataGridViewTextBoxColumn.HeaderText = "LocationCurrent";
            this.locationCurrentDataGridViewTextBoxColumn.Name = "locationCurrentDataGridViewTextBoxColumn";
            this.locationCurrentDataGridViewTextBoxColumn.Width = 150;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.indigoDataSet;
            // 
            // indigoDataSet
            // 
            this.indigoDataSet.DataSetName = "IndigoDataSet";
            this.indigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAsset.Location = new System.Drawing.Point(226, 264);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(182, 46);
            this.btnDeleteAsset.TabIndex = 5;
            this.btnDeleteAsset.Text = "Delete Asset";
            this.btnDeleteAsset.UseVisualStyleBackColor = false;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(477, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 30);
            this.label3.TabIndex = 56;
            this.label3.Text = "Asset Administration";
            // 
            // AssetAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteAsset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.btnCreateAsset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAssetNumber);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.labelPW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AssetAdmin";
            this.Text = "Asset Administration";
            this.Load += new System.EventHandler(this.AssetAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indigoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAssetNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IndigoDataSet indigoDataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private IndigoDataSetTableAdapters.AssetsTableAdapter assetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteAsset;
        private System.Windows.Forms.Label label3;
    }
}