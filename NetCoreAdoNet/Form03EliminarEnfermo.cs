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
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            string connectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadEnfermos();
        }
        private void LoadEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }
        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            //Necesitamos el dato de la inscripcion concatenado
            int inscripcion = int.Parse(this.txtInscripcion.Text);

            string sql = $"delete from ENFERMO where INSCRIPCION=@inscripcion";
            //Debemos confugirar uno o varios parametros
            SqlParameter pamIns = new SqlParameter();
            //NOMBRE DEL PARAMETRO EN LA CONSULTA NO PUEDE SER REPETIDO
            pamIns.ParameterName = "@inscripcion";
            pamIns.DbType = DbType.Int32;
            //PODE DEFECTO LA DIRECCION ES INPUT
            pamIns.Direction = ParameterDirection.Input;
            // el valor del parametro para sustituir en la consulta
            pamIns.Value = inscripcion;
            //AGREGAMOS EL PARAMETRO A LA COLECCION
            this.com.Parameters.Add(pamIns);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //Las consultas de accion devuelven un int con el numero de registros afectados
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            //ELIMINAMOS LOS PARAMETROS DESPUES DE CERRAR
            this.com.Parameters.Clear();
            this.LoadEnfermos();
            MessageBox.Show("Enfermos eliminados: " + registros);
        }
    }
}
