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
    public partial class frmReporte : Form
    {
        private SqlConnection cadenaconexion = new SqlConnection(Properties.Settings.Default.UTNconexion);
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uTNDataSet.sp_reporte' Puede moverla o quitarla según sea necesario.
            this.sp_reporteTableAdapter.Fill(this.uTNDataSet.sp_reporte);
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            
            String Consulta = @"	select LEGAJO ,SUM(total_de_presentes)AS'CANTIDAD DE ASISTENCIAS A CLASES',
	                                sum(total_de_ausentes)AS'CANTIDAD DE INASISTENCIAS A CLASES',
		                            SUM(TOTAL_DE_CASLES)AS'CANTIDAD TOTAL DE CLASES' , 
                                    (CONVERT(FLOAT,(SUM(total_de_presentes))) / SUM(TOTAL_DE_CASLES) * 100)AS 'POCRCENTAJE DE ASISTENCIA'
 	                                from asistencia a 
	                                GROUP BY LEGAJO";
            SqlCommand cmd = new SqlCommand(Consulta, cadenaconexion);
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = cmd;
            DataTable dt = new DataTable();
            a.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
