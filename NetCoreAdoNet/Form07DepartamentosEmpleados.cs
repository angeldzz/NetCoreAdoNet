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
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentoEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentoEmpleados();
            this.LoadDepartamentos();
        }
        private async void LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string departamento in departamentos)
            {
                lstDepartamentos.Items.Add(departamento);
            }
        }
        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEmpleados.Items.Clear();
            string selectedItem = lstDepartamentos.SelectedItem.ToString();
            List<string> empleados = await this.repo.GetEmpleado_X_DepartamentoAsync(selectedItem);
            foreach (string empleado in empleados)
            {
                lstEmpleados.Items.Add(empleado);
            }
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int registro = await this.repo.BorrarEmpleado(lstEmpleados.SelectedItem.ToString());
            MessageBox.Show("Empleados Eliminados: " + registro);
            this.lstDepartamentos_SelectedIndexChanged(null, null);

        }
    }
}
