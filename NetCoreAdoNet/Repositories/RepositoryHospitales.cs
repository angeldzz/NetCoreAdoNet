using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryHospitales()
        {
            string connectionstring = @"Data Source=""LOCALHOST \DEVELOPER"";Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionstring);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                Hospital hos = new Hospital();
                hos.Hospital_Cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hos.Nombre = this.reader["NOMBRE"].ToString();
                hos.Direccion = this.reader["DIRECCION"].ToString();
                hos.Telefono = this.reader["TELEFONO"].ToString();
                hos.Num_cama = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hos);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }
        public async Task CreateHospitalesAsync(int id,string nombre,string direccion, string telefono,int num_cama)
        {
            string sql = "insert into HOSPITAL values(@id,@nombre,@direccion,@telefono,@num_cama)";
            this.com.Parameters.AddWithValue("@id",id);
            this.com.Parameters.AddWithValue("@nombre",nombre);
            this.com.Parameters.AddWithValue("@direccion",direccion);
            this.com.Parameters.AddWithValue("@telefono",telefono);
            this.com.Parameters.AddWithValue("@num_cama",num_cama);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        public async Task UpdateHospitalesAsync(int id, string nombre, string direccion, string telefono, int num_cama)
        {
            string sql = "update HOSPITAL set NOMBRE=@nombre,DIRECCION=@direccion,TELEFONO=@telefono,NUM_CAMA=@num_cama WHERE HOSPITAL_COD=@id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@num_cama", num_cama);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        public async Task DeleteHospitalAsync(int id)
        {
            string sql = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD=@id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
