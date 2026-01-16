using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryUpdateEmpleados()
        {
            string connectionstring = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionstring);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficiosList;
        }
        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = @"select APELLIDO from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("oficio",oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string empleado = this.reader["APELLIDO"].ToString();
                apellidos.Add(empleado);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return apellidos;
        }
        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incrementoSalarial)
        {
            string sql = "update EMP set SALARIO = SALARIO + @incremento  where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@incremento", incrementoSalarial);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }
        public async Task<List<string>> GetCosasSalarialesEmpleadosAsync(string oficio)
        {
            string sql = "SELECT AVG(SALARIO) AS MediaSalarial, SUM(SALARIO) AS SumaSalarial, COUNT(*) AS NumeroEmpleados FROM EMP WHERE OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> calculos = new List<string>();
            string mediaSalarial = "0";
            string sumaSalarial = "0";
            string numeroEmpleados = "0";
            
            if (await this.reader.ReadAsync())
            {
                mediaSalarial = this.reader["MediaSalarial"].ToString();
                sumaSalarial = this.reader["SumaSalarial"].ToString();
                numeroEmpleados = this.reader["NumeroEmpleados"].ToString();
                calculos.Add(mediaSalarial);
                calculos.Add(sumaSalarial);
                calculos.Add(numeroEmpleados);
            }
            
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            
            return calculos;
        }
    }
}
