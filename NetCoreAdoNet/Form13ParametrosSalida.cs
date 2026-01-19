using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region STORED PROCEDURE
/*
 CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
AS
	SELECT * FROM DEPT
GO
create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
(@nombre NVARCHAR(50), @suma int out, @media int out, @personas int out)
AS
	DECLARE @iddept int
	SELECT @iddept = DEPT_NO from DEPT
	where DNOMBRE = @nombre
	--La consulta del procedimiento
	select * from EMP where DEPT_NO=@iddept
	--Rellenamos las variables de salida
	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO)
	from EMP
	where DEPT_NO = @iddept
GO
*/
#endregion
namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionstring = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionstring);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }
        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
        }
        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //TENEMOS UN PARAMETRO DE ENTRADA POR DEFECTO TODOS LOS
            //PARAMETROS SON DE ENTRADA, PODEMOS SEGUIR UTILIZANDO ADDWITHVALUE,
            //CON DICHO PARAMETRO
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombre;
            this.com.Parameters.Add(pamNombre);
            //LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLICITA.
            //EN ESTE EJEMPLO, NO HEMOS PUESTO VALORES POR DEFECTO A LOS PARAMETROS POR LO QUE SN OBLIGATORIOS,SOY UN RATATOPO
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();
            //Dibujamos los parametros
            this.textBox1.Text = pamSuma.Value.ToString();
            this.textBox2.Text = pamMedia.Value.ToString();
            this.textBox3.Text = pamPersonas.Value.ToString();
            //Liberams los recursos de la conexion y demas
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
