namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbHospitales = new ComboBox();
            btnMoficarSalario = new Button();
            label3 = new Label();
            lstPlantilla = new ListBox();
            txtIncremento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 80);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(43, 98);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(177, 23);
            cmbHospitales.TabIndex = 3;
            // 
            // btnMoficarSalario
            // 
            btnMoficarSalario.Location = new Point(163, 127);
            btnMoficarSalario.Name = "btnMoficarSalario";
            btnMoficarSalario.Size = new Size(108, 38);
            btnMoficarSalario.TabIndex = 4;
            btnMoficarSalario.Text = "Modificar Salario";
            btnMoficarSalario.UseVisualStyleBackColor = true;
            btnMoficarSalario.Click += btnMoficarSalario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 186);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(43, 204);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(371, 169);
            lstPlantilla.TabIndex = 6;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(245, 98);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(169, 23);
            txtIncremento.TabIndex = 7;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(txtIncremento);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(btnMoficarSalario);
            Controls.Add(cmbHospitales);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox cmbHospitales;
        private Button btnMoficarSalario;
        private Label label3;
        private ListBox lstPlantilla;
        private TextBox txtIncremento;
    }
}