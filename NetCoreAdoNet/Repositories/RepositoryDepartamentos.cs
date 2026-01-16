using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "select * from DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }
        public async Task CreateDepartamentosAsync(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id,@nombre,@localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNom = new SqlParameter("@nombre", nombre);
            SqlParameter pamLoc = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNom);
            this.com.Parameters.Add(pamLoc);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        //Creacion de update parametros
        public async Task UpdateDepartamentosAsync(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad WHERE DEPT_NO=@id";
            //TENEMOS UN METODO EN EL COMMAND QUE PERMITE AÑADIR PARAMETROS SIN CREAR OBJETOS
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        public async Task DeleteDepartamentoAsync(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@id";
            this.com.Parameters.AddWithValue("@id",id);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
