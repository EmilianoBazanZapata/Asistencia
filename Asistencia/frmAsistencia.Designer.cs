namespace Asistencia
{
    partial class frmAsistencia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.rbtPresente = new System.Windows.Forms.RadioButton();
            this.rbtAusente = new System.Windows.Forms.RadioButton();
            this.txtLgajoAbuscar = new System.Windows.Forms.TextBox();
            this.btnLegajo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabarEditado = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(397, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(391, 345);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(63, 93);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(63, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(63, 147);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.Location = new System.Drawing.Point(63, 173);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 4;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(249, 383);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(112, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar Aistencia";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(33, 382);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(794, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(339, 345);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(397, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "REGISTRADOS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Location = new System.Drawing.Point(794, 65);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(339, 20);
            this.txtRegistro.TabIndex = 12;
            this.txtRegistro.Text = "PRESENTES";
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtPresente
            // 
            this.rbtPresente.AutoSize = true;
            this.rbtPresente.Location = new System.Drawing.Point(63, 201);
            this.rbtPresente.Name = "rbtPresente";
            this.rbtPresente.Size = new System.Drawing.Size(67, 17);
            this.rbtPresente.TabIndex = 13;
            this.rbtPresente.Text = "Presente";
            this.rbtPresente.UseVisualStyleBackColor = true;
            // 
            // rbtAusente
            // 
            this.rbtAusente.AutoSize = true;
            this.rbtAusente.Location = new System.Drawing.Point(63, 225);
            this.rbtAusente.Name = "rbtAusente";
            this.rbtAusente.Size = new System.Drawing.Size(64, 17);
            this.rbtAusente.TabIndex = 14;
            this.rbtAusente.Text = "Ausente";
            this.rbtAusente.UseVisualStyleBackColor = true;
            // 
            // txtLgajoAbuscar
            // 
            this.txtLgajoAbuscar.Location = new System.Drawing.Point(607, 29);
            this.txtLgajoAbuscar.Name = "txtLgajoAbuscar";
            this.txtLgajoAbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtLgajoAbuscar.TabIndex = 15;
            // 
            // btnLegajo
            // 
            this.btnLegajo.Location = new System.Drawing.Point(713, 27);
            this.btnLegajo.Name = "btnLegajo";
            this.btnLegajo.Size = new System.Drawing.Size(75, 23);
            this.btnLegajo.TabIndex = 16;
            this.btnLegajo.Text = "Buscar";
            this.btnLegajo.UseVisualStyleBackColor = true;
            this.btnLegajo.Click += new System.EventHandler(this.btnLegajo_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(397, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "INGRESE UN LEGAJO";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(794, 26);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 18;
            this.btnRefrescar.Text = "Rerescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(168, 383);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnGrabarEditado
            // 
            this.btnGrabarEditado.Location = new System.Drawing.Point(249, 382);
            this.btnGrabarEditado.Name = "btnGrabarEditado";
            this.btnGrabarEditado.Size = new System.Drawing.Size(112, 23);
            this.btnGrabarEditado.TabIndex = 21;
            this.btnGrabarEditado.Text = "Grabar De Nuevo";
            this.btnGrabarEditado.UseVisualStyleBackColor = true;
            this.btnGrabarEditado.Visible = false;
            this.btnGrabarEditado.Click += new System.EventHandler(this.btnGrabarEditado_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(875, 27);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(253, 23);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Reporte de Asistencia";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(33, 13);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 23;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Legajo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Curso : ";
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnGrabarEditado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnLegajo);
            this.Controls.Add(this.txtLgajoAbuscar);
            this.Controls.Add(this.rbtAusente);
            this.Controls.Add(this.rbtPresente);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsistencia";
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.RadioButton rbtPresente;
        private System.Windows.Forms.RadioButton rbtAusente;
        private System.Windows.Forms.TextBox txtLgajoAbuscar;
        private System.Windows.Forms.Button btnLegajo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabarEditado;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}