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
        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
