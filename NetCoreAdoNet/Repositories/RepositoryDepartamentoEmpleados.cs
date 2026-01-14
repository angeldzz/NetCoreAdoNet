
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentoEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryDepartamentoEmpleados()
        {
            string connectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "select distinct DNOMBRE from DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string DEPTnombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(DEPTnombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }
        public async Task<List<string>> GetEmpleado_X_DepartamentoAsync(string deptSeleccionado)
        {
            string sql = @"SELECT E.APELLIDO 
                   FROM EMP E
                   INNER JOIN DEPT D ON E.DEPT_NO = D.DEPT_NO
                   WHERE D.DNOMBRE = @deptSeleccionado";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@deptSeleccionado", deptSeleccionado);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return empleados;
        }
        public async Task<int> BorrarEmpleado(string empleado)
        {
            string sql = @"DELETE FROM EMP WHERE EMP.APELLIDO = @apellido";
            this.com.Parameters.AddWithValue("@apellido", empleado);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }
    }
}
