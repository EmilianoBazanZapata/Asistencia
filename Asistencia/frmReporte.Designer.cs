namespace Asistencia
{
    partial class frmReporte
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.uTNDataSet = new Asistencia.UTNDataSet();
            this.spreporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_reporteTableAdapter = new Asistencia.UTNDataSetTableAdapters.sp_reporteTableAdapter();
            this.lEGAJODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lEGAJODataGridViewTextBoxColumn,
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn,
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn,
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn,
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spreporteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // uTNDataSet
            // 
            this.uTNDataSet.DataSetName = "UTNDataSet";
            this.uTNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporteBindingSource
            // 
            this.spreporteBindingSource.DataMember = "sp_reporte";
            this.spreporteBindingSource.DataSource = this.uTNDataSet;
            // 
            // sp_reporteTableAdapter
            // 
            this.sp_reporteTableAdapter.ClearBeforeFill = true;
            // 
            // lEGAJODataGridViewTextBoxColumn
            // 
            this.lEGAJODataGridViewTextBoxColumn.DataPropertyName = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.HeaderText = "LEGAJO";
            this.lEGAJODataGridViewTextBoxColumn.Name = "lEGAJODataGridViewTextBoxColumn";
            this.lEGAJODataGridViewTextBoxColumn.ReadOnly = true;
            this.lEGAJODataGridViewTextBoxColumn.Width = 150;
            // 
            // cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn
            // 
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD DE ASISTENCIAS A CLASES";
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn.HeaderText = "CANTIDAD DE ASISTENCIAS A CLASES";
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn.Name = "cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn";
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn.Width = 150;
            // 
            // cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn
            // 
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD DE INASISTENCIAS A CLASES";
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn.HeaderText = "CANTIDAD DE INASISTENCIAS A CLASES";
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn.Name = "cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn";
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn.Width = 150;
            // 
            // cANTIDADTOTALDECLASESDataGridViewTextBoxColumn
            // 
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD TOTAL DE CLASES";
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn.HeaderText = "CANTIDAD TOTAL DE CLASES";
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn.Name = "cANTIDADTOTALDECLASESDataGridViewTextBoxColumn";
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADTOTALDECLASESDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn
            // 
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn.DataPropertyName = "POCRCENTAJE DE ASISTENCIA";
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn.HeaderText = "POCRCENTAJE DE ASISTENCIA";
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn.Name = "pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn";
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn.ReadOnly = true;
            this.pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn.Width = 150;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolver;
        private UTNDataSet uTNDataSet;
        private System.Windows.Forms.BindingSource spreporteBindingSource;
        private UTNDataSetTableAdapters.sp_reporteTableAdapter sp_reporteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEGAJODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDEASISTENCIASACLASESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDEINASISTENCIASACLASESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADTOTALDECLASESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCRCENTAJEDEASISTENCIADataGridViewTextBoxColumn;
    }
}