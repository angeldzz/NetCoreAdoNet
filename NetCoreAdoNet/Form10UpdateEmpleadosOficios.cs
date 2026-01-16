using NetCoreAdoNet.Repositories;
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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }
        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }
        private async void btnSubirSalarios_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtSalario.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int registros = await this.repo.UpdateSalarioEmpleadosAsync(oficio, incremento);
            MessageBox.Show($"Registros afectados {registros}");
            await this.LoadOficios();
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> apellidos = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();
                foreach (string ape in apellidos)
                {
                    this.lstEmpleados.Items.Add(ape);
                }
            }
            
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> opc = await this.repo.GetCosasSalarialesEmpleadosAsync(oficio);
                lblMaximoSalario.Text = opc[0];
                lblMediaSalarial.Text = opc[1];
                lblSumaSalarial.Text = opc[2];
            }
            
        }
    }
}
