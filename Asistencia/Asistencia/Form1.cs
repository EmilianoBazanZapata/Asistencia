using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class Form1 : Form
    {
        AccesoDato oDato = new AccesoDato(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CargarCombo(cbxCurso, "CURSOS");
            PopulatePositionComboBox();
            CargarGrilla();
        }

        ////CARGO EL COMBO BOX PARA VER LOS CURSOS 
        //public void CargarCombo(ComboBox Combo, string NombreTabla)
        //{
        //    Alumno Ma = new Alumno();
        //    DataTable DT = new DataTable();
        //    DT = oDato.ConsultarTabla(NombreTabla);
        //    Combo.DataSource = DT;
        //    Combo.ValueMember = DT.Columns[0].ColumnName;
        //    Combo.DisplayMember = DT.Columns[1].ColumnName;
        //    Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        //    oDato.Desconectar();
        //}

        private void PopulatePositionComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True"))
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(@"	SELECT *
                                                                FROM CURSOS C", sqlCon);
                DataTable Dt = new DataTable();
                sqlDa.Fill(Dt);
                cbxCurso.ValueMember = "COD_CURSO";
                cbxCurso.DisplayMember = "NOM_CURSO";
                DataRow TopItem = Dt.NewRow();
                //TopItem[0] = 0;
                //TopItem[1] = "-SELECCIONE UN CURSO-";
                //Dt.Rows.InsertAt(TopItem, 0);
                cbxCurso.DataSource = Dt;



            }



        }

        public static String Nombre;
        public static String Apellido;
        public static int Legajo;
        public static String Curso;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Legajo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Curso = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        //////////////////////////////BOTONES/////////////////////////////////////

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtLegajo.Text = Convert.ToString(Legajo);
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            cbxCurso.Text = Curso;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
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
            else
            {
                A.pLegajo = Convert.ToInt32(txtLegajo.Text);
                A.pNombre = txtNombre.Text;
                A.pApellido = txtApellido.Text;
                A.pCurso = cbxCurso.SelectedIndex + 1;


                SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
                var sql = "INSERT INTO ALUMNOS VALUES(@Legajo,@Nombre , @Apellido , @Curso )";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@Legajo", A.pLegajo);
                cmd.Parameters.AddWithValue("@Nombre", A.pNombre);
                cmd.Parameters.AddWithValue("@Apellido", A.pApellido);
                cmd.Parameters.AddWithValue("@Curso", A.pCurso);

                cmd.ExecuteNonQuery();
                conexion.Close();
                CargarGrilla();
            }
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

                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-1E6MN4M\SQLEXPRESS;Initial Catalog=UTN;Integrated Security=True");
                sqlCon.Open();
                SqlCommand Com = new SqlCommand("SP_ACTUALIZAR", sqlCon);
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
            }
        }
    }
}
