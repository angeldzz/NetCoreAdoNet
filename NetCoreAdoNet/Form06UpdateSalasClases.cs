using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form06UpdateSalasClases : Form
    {
        RepositorySales repo;
        public Form06UpdateSalasClases()
        {

            InitializeComponent();
            this.repo = new RepositorySales();
            this.LoadSalas();
        }
        private async void LoadSalas()
        {
            List<string> salas = await this.repo.GetNombreSalasAsync();
            this.lstSalas.Items.Clear();
            foreach (string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }
        private async void btnUpdateSalas_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNuevoNombre.Text;
            int registros = await this.repo.UpdateSalaAsync(newName,oldName);
            MessageBox.Show("Modificados: " + registros);
            this.LoadSalas();
        }
    }
}
