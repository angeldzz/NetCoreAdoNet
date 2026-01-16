using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentos();
        }
        private async Task LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            lstDepartamentos.Items.Clear();
            foreach (Departamento departamento in departamentos)
            {
                lstDepartamentos.Items.Add($"{departamento.IdDepartamento} - {departamento.Nombre} - {departamento.Localidad}");
            }
        }
        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.CreateDepartamentosAsync(id,nombre,localidad);
            await this.LoadDepartamentos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamentosAsync(id, nombre, localidad);
            await this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDepartamentoAsync(id);
            await this.LoadDepartamentos();
        }
    }
}
