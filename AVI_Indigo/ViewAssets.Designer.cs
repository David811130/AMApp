namespace AVI_Indigo
{
    partial class ViewAssets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAssets));
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.indigoDataSet = new AVI_Indigo.IndigoDataSet();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTableAdapter = new AVI_Indigo.IndigoDataSetTableAdapters.AssetsTableAdapter();
            this.assetsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetsViewDataSet = new AVI_Indigo.AssetsViewDataSet();
            this.assetsTableAdapter1 = new AVI_Indigo.AssetsViewDataSetTableAdapters.AssetsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbWH = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.indigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 581);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(280, 46);
            this.BtnMainMenu.TabIndex = 45;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(534, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 46;
            this.label3.Text = "Asset View";
            // 
            // indigoDataSet
            // 
            this.indigoDataSet.DataSetName = "IndigoDataSet";
            this.indigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.indigoDataSet;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // assetsBindingSource1
            // 
            this.assetsBindingSource1.DataMember = "Assets";
            this.assetsBindingSource1.DataSource = this.assetsViewDataSet;
            // 
            // assetsViewDataSet
            // 
            this.assetsViewDataSet.DataSetName = "AssetsViewDataSet";
            this.assetsViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
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
            this.locationCurrentDataGridViewTextBoxColumn,
            this.MovementDate,
            this.LocationOld});
            this.dataGridView1.DataSource = this.assetsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 377);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbWH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbModel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbManufacturer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 111);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Manufacturer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(584, 51);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(221, 21);
            this.cbManufacturer.TabIndex = 54;
            this.cbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbManufacturer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(932, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Model";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(980, 53);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(221, 21);
            this.cbModel.TabIndex = 56;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 61;
            this.label9.Text = "Warehouse";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbWH
            // 
            this.cbWH.FormattingEnabled = true;
            this.cbWH.Location = new System.Drawing.Point(195, 48);
            this.cbWH.Name = "cbWH";
            this.cbWH.Size = new System.Drawing.Size(221, 21);
            this.cbWH.TabIndex = 60;
            this.cbWH.SelectedIndexChanged += new System.EventHandler(this.cbWH_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(972, 581);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(280, 46);
            this.btnPrint.TabIndex = 51;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.assetNumDataGridViewTextBoxColumn.HeaderText = "Asset Number";
            this.assetNumDataGridViewTextBoxColumn.Name = "assetNumDataGridViewTextBoxColumn";
            this.assetNumDataGridViewTextBoxColumn.Width = 80;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 110;
            // 
            // serialNumDataGridViewTextBoxColumn
            // 
            this.serialNumDataGridViewTextBoxColumn.DataPropertyName = "SerialNum";
            this.serialNumDataGridViewTextBoxColumn.HeaderText = "Serial Number";
            this.serialNumDataGridViewTextBoxColumn.Name = "serialNumDataGridViewTextBoxColumn";
            this.serialNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationCurrentDataGridViewTextBoxColumn
            // 
            this.locationCurrentDataGridViewTextBoxColumn.DataPropertyName = "LocationCurrent";
            this.locationCurrentDataGridViewTextBoxColumn.HeaderText = "Current Location";
            this.locationCurrentDataGridViewTextBoxColumn.Name = "locationCurrentDataGridViewTextBoxColumn";
            this.locationCurrentDataGridViewTextBoxColumn.Width = 150;
            // 
            // MovementDate
            // 
            this.MovementDate.DataPropertyName = "MovementDate";
            this.MovementDate.HeaderText = "Date Moved to Location";
            this.MovementDate.Name = "MovementDate";
            this.MovementDate.ReadOnly = true;
            this.MovementDate.Width = 250;
            // 
            // LocationOld
            // 
            this.LocationOld.DataPropertyName = "LocationOld";
            this.LocationOld.HeaderText = "Previous Location";
            this.LocationOld.Name = "LocationOld";
            this.LocationOld.Width = 150;
            // 
            // ViewAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewAssets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAssets";
            this.Load += new System.EventHandler(this.ViewAssets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Label label3;
        private IndigoDataSet indigoDataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private IndigoDataSetTableAdapters.AssetsTableAdapter assetsTableAdapter;
        private AssetsViewDataSet assetsViewDataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource1;
        private AssetsViewDataSetTableAdapters.AssetsTableAdapter assetsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbWH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationOld;
    }
}