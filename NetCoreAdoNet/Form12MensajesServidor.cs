using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetCoreAdoNet
{
    #region PROCEDIMIENTOS ALMACENADOS
    /*
     CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
AS
	SELECT * FROM DEPT
GO
CREATE PROCEDURE SP_INSERT_DEPARTAMENTO
(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
AS
	INSERT INTO DEPT VALUES(@numero, @nombre, @localidad)
GO
execute SP_ALL_DEPARTAMENTOS
execute SP_INSERT_DEPARTAMENTO 12, "ANGEL", "PINTO"
    */
    #endregion
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            //AGREGAMOS EL EVENTO PARA CAPTURAR MENSAJES
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblServidor.Text = e.Message;
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            await this.cn.OpenAsync();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.lstDepartamentos.Items.Clear();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                int DEPTnumero = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add($"{DEPTnumero} - {nombre} - {loc}");
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
        }
        private async void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            this.lblServidor.Text = "";
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", int.Parse(this.txtId.Text));
            this.com.Parameters.AddWithValue("@nombre", this.txtNombre.Text);
            this.com.Parameters.AddWithValue("@localidad", this.txtLocalidad.Text);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registro = this.com.ExecuteNonQuery();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            await this.LoadDepartamentos();
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";

            MessageBox.Show($"Registros actualizados {registro}");
        }

        private async void btnReaload_Click(object sender, EventArgs e)
        {
            await this.LoadDepartamentos();
        }
    }
}
