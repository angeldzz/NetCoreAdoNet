using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form02BuscardorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscardorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //Vamos a concatenar, por lo que nuestro salario sera un string
            string salario = this.txtSalario.Text;
            //Consulta SQL
            string sql = "select * from EMP where SALARIO >= " + salario;
            //Configuramos el comando
            //Connection
            this.com.Connection = this.cn;
            //Tipo de consulta
            this.com.CommandType = CommandType.Text;
            //la consulta
            this.com.CommandText = sql;
            //Entrar y salir
            //Abrimos conexion
            this.cn.Open();
            //Ejecutamos Las consultas
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add($"{apellido} - {sal}$");
            }
        }
    }
}
