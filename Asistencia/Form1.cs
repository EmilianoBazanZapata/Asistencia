using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class Form1 : Form
    {
        public static String Nombre;
        public static String Apellido;
        public static int Legajo;
        public static String Curso;
        public SqlConnection cadenaconexion = new SqlConnection(Properties.Settings.Default.UTNconexion);


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                CargarGrilla();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                CargarCombo(cbxCurso, "CURSOS");
                cbxCurso.Text = "";
                PorDefecto();
            }
            catch (Exception)
            {

                MessageBox.Show("todavia no hay alumnos cargados");
            }
        }

        //////////////////////////////Grilla/////////////////////////////////////
        public void CargarCombo(ComboBox Combo, string NombreTabla)
        {

            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.UTNconexion);
            String Consulta = @"select * from cursos";
            DataTable DT = new DataTable();
            SqlCommand cmd = new SqlCommand(Consulta, sqlcon);
            sqlcon.Open();
            DT.Load(cmd.ExecuteReader());
            Combo.DataSource = DT;
            Combo.ValueMember = DT.Columns[0].ColumnName;
            Combo.DisplayMember = DT.Columns[1].ColumnName;
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            sqlcon.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Campos();
            }
            catch (Exception)
            {

                MessageBox.Show("esta celda no tiene nada ");
            }
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void CargarGrilla()
        {
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.UTNconexion);
            String Consulta = @"	SELECT LEGAJO , NOM_ALUMNO AS'NOMBRE', APE_ALUMNO AS'APELLIDO',C.NOM_CURSO AS 'CURSO'
	                                FROM ALUMNOS A , CURSOS C 
	                                WHERE A.COD_CURSO = C.COD_CURSO";
            SqlCommand cmd = new SqlCommand(Consulta, sqlcon);
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = cmd;
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //////////////////////////////BOTONES/////////////////////////////////////
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Campos())
            {
                ActivarCampos();
                ActivarBotonesActualizar();
                txtLegajo.Text = Convert.ToString(Legajo);
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                cbxCurso.Text = Curso;
            }
            else
            {
                MessageBox.Show("intente registrar un alumno para poder editar sus datos");
            }
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarBotonesIngreso();
            ActivarCampos();
        }
        private void btnAgregarEditado_Click(object sender, EventArgs e)
        {

            Alumno A = new Alumno();
            if (txtLegajo.Text == "")
            {
                MessageBox.Show("Debe Ingresar El Legajo Del Alumno");
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar El Nombre Del Alumno");
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe Ingresar El Apellido Del Alumno");
            }
            if ((txtLegajo.Text != "") && (txtNombre.Text != "") && (txtApellido.Text != ""))
            {


                cadenaconexion.Open();
                SqlCommand Com = new SqlCommand("SP_ACTUALIZAR", cadenaconexion);
                Com.CommandType = CommandType.StoredProcedure;
                {
                    A.pLegajo = Convert.ToInt32(txtLegajo.Text);
                    A.pNombre = txtNombre.Text;
                    A.pApellido = txtApellido.Text;
                    A.pCurso = cbxCurso.SelectedIndex + 1;

                    Com.Parameters.AddWithValue("@Legajo", A.pLegajo);
                    Com.Parameters.AddWithValue("@Nombre", A.pNombre);
                    Com.Parameters.AddWithValue("@Apellido", A.pApellido);
                    Com.Parameters.AddWithValue("@Curso", A.pCurso);
                    Com.ExecuteNonQuery();
                    CargarGrilla();
                }
                cadenaconexion.Close();
            }
            PorDefecto();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PorDefecto();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection sqcon = new SqlConnection(Properties.Settings.Default.UTNconexion);
            Alumno A = new Alumno();
            A.pLegajo = Convert.ToInt32(txtLegajo.Text);

            var sql = @"delete from asistencia 
                       where legajo = @Legajo
                       delete from ALUMNOS 
                       where LEGAJO = @Legajo";
            cadenaconexion.Open();
            SqlCommand cmd = new SqlCommand(sql, cadenaconexion);

            cmd.Parameters.AddWithValue("@Legajo", A.pLegajo);
            cmd.ExecuteNonQuery();
            cadenaconexion.Close();
            CargarGrilla();
            PorDefecto();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Buscar();

            GrabarAlumno();

            PorDefecto();
        }
        private void aistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia A = new frmAsistencia();
            A.Show();
            this.Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //////////////////////////////METODOS////////////////////////////////////////
        private void ActivarBotonesIngreso()
        {
            btnEditar.Enabled = false;
            btnAgregarEditado.Enabled = false;
            btnAgregarEditado.Visible = false;
            btnNuevo.Enabled = false;
            btnGrabar.Visible = true;
            btnGrabar.Enabled = true;
            dataGridView1.Enabled = false;
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxCurso.Text = "";
        }
        private void ActivarBotonesActualizar()
        {
            btnEditar.Enabled = false;
            btnAgregarEditado.Enabled = true;
            btnAgregarEditado.Visible = true;
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
            btnGrabar.Visible = false;
            dataGridView1.Enabled = false;
            btnEliminar.Visible = true;
        }
        private void ActivarCampos()
        {
            txtLegajo.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cbxCurso.Enabled = true;
        }
        private void PorDefecto()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnAgregarEditado.Enabled = false;
            btnGrabar.Enabled = false;
            dataGridView1.Enabled = true;
            txtLegajo.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cbxCurso.Enabled = false;
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxCurso.Text = "";
            btnEliminar.Visible = false;
        }
        private bool Campos()
        {
            Boolean resultado = false;
            try
            {
                Legajo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Curso = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("todavia no hay alumnos registrados");
                resultado = false;
            }
            return resultado;
        }
        public bool Buscar()
        {
            bool resultado = false;
            if (txtLegajo.Text == "")
            {
                MessageBox.Show("Debe Ingresar El Legajo Del Alumno");
            }
            else
            {
                Alumno A = new Alumno();
                A.pLegajo = Convert.ToInt32(txtLegajo.Text);


                var sql = string.Format("select legajo from alumnos where legajo = @Legajo");
                SqlCommand comando = new SqlCommand(sql, cadenaconexion);
                comando.Parameters.AddWithValue("@Legajo", A.pLegajo);
                cadenaconexion.Open();
                SqlDataReader dr = null;
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("el alumno que quiere registrar ya existe");
                    resultado = true;

                }
                else
                {
                    resultado = false;
                }
                cadenaconexion.Close();
            }
            return resultado;
        }
        public void GrabarAlumno()
        {
            Alumno A = new Alumno();
            if (!Buscar())
            {
                if (txtLegajo.Text == "")
                {

                    MessageBox.Show("Debe Ingresar El Legajo Del Alumno");
                }
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe Ingresar El Nombre Del Alumno");
                }
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Debe Ingresar El Apellido Del Alumno");
                }
                else
                {
                    A.pLegajo = Convert.ToInt32(txtLegajo.Text);
                    A.pNombre = txtNombre.Text;
                    A.pApellido = txtApellido.Text;
                    A.pCurso = cbxCurso.SelectedIndex + 1;



                    var sql = "INSERT INTO ALUMNOS VALUES(@Legajo,@Nombre , @Apellido , @Curso )";
                    cadenaconexion.Open();
                    SqlCommand cmd = new SqlCommand(sql, cadenaconexion);

                    cmd.Parameters.AddWithValue("@Legajo", A.pLegajo);
                    cmd.Parameters.AddWithValue("@Nombre", A.pNombre);
                    cmd.Parameters.AddWithValue("@Apellido", A.pApellido);
                    cmd.Parameters.AddWithValue("@Curso", A.pCurso);

                    cmd.ExecuteNonQuery();
                    cadenaconexion.Close();
                    CargarGrilla();
                }
            }

        }
        //////////////////////////////validaciones/////////////////////////////////////
        //validacion para verificar si ingreso los caracteres correctos 
        //el key press es un evento del textbox
        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte fr = new frmReporte();
            fr.Show();
        }

        private void elegirAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String Consulta = @"SELECT TOP 3 A.LEGAJO , A.NOM_ALUMNO AS'NOMBRE', A.APE_ALUMNO AS'APELLIDO', C.NOM_CURSO AS 'CURSO' 
	                                    FROM ALUMNOS A , CURSOS C
	                                    WHERE A.COD_CURSO = C.COD_CURSO
                                        ORDER BY NEWID()";
            SqlCommand cmd = new SqlCommand(Consulta, cadenaconexion);
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = cmd;
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }
    }
}
