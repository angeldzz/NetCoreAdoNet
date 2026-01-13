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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string conectionString;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.conectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.conectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblConexion.Text = "La Conexion esta pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblConexion.BackColor = Color.LightGreen;
            }
            catch (SqlException exSql)
            {
                this.lblConexion.Text = "Error: " + exSql.ToString();
            }
            catch (Exception ex)
            {
                this.lblConexion.Text = "Error " + ex.ToString();
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblConexion.BackColor = Color.LightCoral;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Para leer registros logicamente necesitamos la conexion Open();
            string sql = "select * from EMP";
            //Indicamos la conexion a utilizar
            this.com.Connection = this.cn;
            //Indicamos tipo de consulta a realizar
            this.com.CommandType = CommandType.Text;
            //Incluimos la consutla en el command
            this.com.CommandText = sql;
            //Aqui deberiamos abrir la conexion
            //Ejecutar la consulta
            //Utilizamos ExeuteReader() que devuelve un DataReader
            this.reader = this.com.ExecuteReader();
            //Para la estructura de la tabla se utiliza for
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                //Leemos la primera columna de la tabla
                string columna = this.reader.GetName(i);
                //Leemos el tipo de dato de la primera columnaa
                string tipo = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTipos.Items.Add(tipo);
            }
            while (this.reader.Read())
            {
                //Leemos simepre el primer registro(APELLIDO)

                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}
