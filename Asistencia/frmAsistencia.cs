using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class frmAsistencia : Form
    {
        DataTable table = new DataTable();
        public static String Nombre;
        public static String Apellido;
        public static int Legajo;
        public static String Curso;
        public static String Asistencia;
        public int Fila;

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarGrilla2();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Legajo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Curso = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLegajo.Text = Convert.ToString(Legajo);
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtCurso.Text = Curso;
        }
        private void CargarGrilla()
        {
            SqlConnection cadenaconexion = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
            String Consulta = @"	SELECT LEGAJO , NOM_ALUMNO AS'NOMBRE', APE_ALUMNO AS'APELLIDO',C.NOM_CURSO AS 'CURSO'
	                                FROM ALUMNOS A , CURSOS C 
	                                WHERE A.COD_CURSO = C.COD_CURSO";
            SqlCommand cmd = new SqlCommand(Consulta, cadenaconexion);
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = cmd;
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void CargarGrilla2()
        {
            SqlConnection cadenaconexion = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
            String Consulta = @"	SELECT  A.LEGAJO , NOM_ALUMNO AS'NOMBRE', APE_ALUMNO AS'APELLIDO',  C.NOM_CURSO AS 'CURSO' , AA.FECHA AS 'FECHA'
	                                FROM ALUMNOS A , CURSOS C , ASISTENCIA AA 
	                                WHERE A.COD_CURSO = C.COD_CURSO 
	                                AND AA.LEGAJO = A.LEGAJO
	                                AND AA.PRESENTE  = 1
	                                AND DAY(AA.FECHA) = DAY(GETDATE())
	                                AND MONTH(AA.FECHA) = MONTH(GETDATE())
	                                AND YEAR(AA.FECHA) = YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(Consulta, cadenaconexion);
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = cmd;
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Legajo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Curso = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLegajo.Text = Convert.ToString(Legajo);
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtCurso.Text = Curso;
            }
            catch (Exception)
            {
                //al no saber por que no carga las celdas en el momento del clic trate de ver si era por algun error 
                MessageBox.Show("intente de nuevo");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Alumno A = new Alumno();
            A.pLegajo = Convert.ToInt32(txtLegajo.Text);
            if (rbtPresente.Checked)
                A.pPresente = true;
            else
                A.pPresente = false;
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
            sqlCon.Open();
            SqlCommand Com = new SqlCommand("SP_ASISTENCIA", sqlCon);
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.AddWithValue("@LEGAJO", A.pLegajo);
            Com.Parameters.AddWithValue("@PRSENTE", A.pPresente);

            Com.ExecuteNonQuery();
            CargarGrilla2();
            sqlCon.Close();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Close();
        }

        private void btnLegajo_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
            try
            {
                Alumno A = new Alumno();
                A.pLegajo = Convert.ToInt32(txtLgajoAbuscar.Text);


                sqlCon.Open();
                SqlCommand Com = new SqlCommand("SP_INFORMACION", sqlCon);
                Com.CommandType = CommandType.StoredProcedure;
                Com.Parameters.AddWithValue("@LEGAJO", A.pLegajo);


                SqlCommand Com2 = new SqlCommand("SP_ALUMNO", sqlCon);
                Com2.CommandType = CommandType.StoredProcedure;
                Com2.Parameters.AddWithValue("@LEGAJO", txtLgajoAbuscar.Text);
                SqlDataAdapter a2 = new SqlDataAdapter();
                a2.SelectCommand = Com2;
                DataTable dt2 = new DataTable();
                a2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                Com2.ExecuteNonQuery();

                SqlDataAdapter a = new SqlDataAdapter();
                a.SelectCommand = Com;
                DataTable dt = new DataTable();
                a.Fill(dt);
                dataGridView2.DataSource = dt;
                Com.ExecuteNonQuery();
                sqlCon.Close();
                txtLegajo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCurso.Text = "";
                rbtAusente.Checked = false;
                rbtPresente.Checked = false;
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = true;
                MessageBox.Show("se deshabiito la primer grilla y se habilito la segunda");
            }
            catch (Exception)
            {

                MessageBox.Show("ingrese un legajo para buscar");
            }
            finally
            {
                sqlCon.Close();
            }
          
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Legajo = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                Nombre = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                Apellido = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                Curso = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                Asistencia = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                txtLegajo.Text = Convert.ToString(Legajo);
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtCurso.Text = Curso;
                if (Asistencia == "PRESENTE")
                {
                    rbtPresente.Checked = true;
                }
                else
                {
                    rbtAusente.Checked = true;
                }
            }
            catch (Exception)
            {
                //al no saber por que no carga las celdas en el momento del clic trate de ver si era por algun error 
                MessageBox.Show("intente  buscar el legajo del alumno y luego aga clic en una fila");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarGrilla2();
            MessageBox.Show("se logro traer todos los registros iniciales exitosamente");
        }
    }
}
