using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRUEBA_ENGEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CONEXION.Conectar();
            string CONSULTA2 = "SELECT * FROM CLIENTES_POS WHERE NOMBRES= '" + text_buscar.Text + "' Or APELLIDOS= '"+ text_buscar.Text +"'or IDENTIFICACCION='"+Text_buscar.txt";
            SqlDataAdapter adap = new SqlDataAdapter(CONSULTA2, CONEXION.Conectar());
            DataTable dt = new DataTable();
            SqlCommand com1 = new SqlCommand(CONSULTA2, CONEXION.Conectar());
            SqlDataReader lector;
            lector = com1.ExecuteReader();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONEXION.Conectar();
            string INSERTAR = "INSERT INTO CLIENTES_POS (NOMBRES,APELLIDOS,IDENTIFICACION,CORREO)VALUES(@NOMBRES,@APELLIDOS,@IDENTIFICACION, @CORREO)";
            SqlCommand cmd1 = new SqlCommand(INSERTAR, CONEXION.Conectar());
            cmd1.Parameters.AddWithValue("@NOMBRES", text_nombres.Text);
            cmd1.Parameters.AddWithValue("@APELLIDOS", text_apellidos.Text);
            cmd1.Parameters.AddWithValue("@IDENTIFICACION", text_identificacion.Text);
            cmd1.Parameters.AddWithValue("@CORREO", text_correo.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Se han agregado los datos");

            dataGridView1.DataSource = present_grid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CONEXION.Conectar();
            MessageBox.Show("CONEXION EFECTUADA");

            dataGridView1.DataSource = present_grid();
        }

        public DataTable present_grid()
        {
            CONEXION.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CLIENTES_POS";
            SqlCommand cmd = new SqlCommand(consulta, CONEXION.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                text_nombres.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                text_apellidos.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                text_identificacion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                text_correo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }

            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONEXION.Conectar();
            string modificar = "UPDATE CLIENTES_POS SET NOMBRES= @NOMBRES, APELLIDOS= @APELLIDOS, IDENTIFICACION= @IDENTIFICACION,CORREO= @CORREO WHERE IDENTIFICACION= @IDENTIFICACION ";
            SqlCommand cmd2 = new SqlCommand(modificar, CONEXION.Conectar());

            cmd2.Parameters.AddWithValue("@NOMBRES", text_nombres.Text);
            cmd2.Parameters.AddWithValue("@APELLIDOS", text_apellidos.Text);
            cmd2.Parameters.AddWithValue("@IDENTIFICACION", text_identificacion.Text);
            cmd2.Parameters.AddWithValue("@CORREO", text_correo.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Se han modificado los datos");

            dataGridView1.DataSource = present_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            CONEXION.Conectar();

            string ELIMINAR = "DELETE FROM CLIENTES_POS WHERE NOMBRES = @NOMBRES";
            SqlCommand cmd3 = new SqlCommand(ELIMINAR, CONEXION.Conectar());
            cmd3.Parameters.AddWithValue("@NOMBRES", text_nombres.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Se han eliminado los datos");


            dataGridView1.DataSource = present_grid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            text_nombres.Clear();
            text_apellidos.Clear();
            text_identificacion.Clear();
            text_correo.Clear();
            text_nombres.Focus();

            dataGridView1.DataSource = present_grid();


        }

        private void text_apellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
