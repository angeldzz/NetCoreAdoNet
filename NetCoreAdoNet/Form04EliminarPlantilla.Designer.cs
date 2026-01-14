namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            btnEliminarPlantilla = new Button();
            label1 = new Label();
            txtEmpleadoNO = new TextBox();
            lbl2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // btnEliminarPlantilla
            // 
            btnEliminarPlantilla.Location = new Point(12, 69);
            btnEliminarPlantilla.Name = "btnEliminarPlantilla";
            btnEliminarPlantilla.Size = new Size(100, 49);
            btnEliminarPlantilla.TabIndex = 0;
            btnEliminarPlantilla.Text = "Eliminar Plantilla";
            btnEliminarPlantilla.UseVisualStyleBackColor = true;
            btnEliminarPlantilla.Click += btnEliminarPlantilla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "EMPLEADO_NO";
            // 
            // txtEmpleadoNO
            // 
            txtEmpleadoNO.Location = new Point(12, 40);
            txtEmpleadoNO.Name = "txtEmpleadoNO";
            txtEmpleadoNO.Size = new Size(100, 23);
            txtEmpleadoNO.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(143, 22);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(49, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(143, 40);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(204, 349);
            lstPlantilla.TabIndex = 4;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(lbl2);
            Controls.Add(txtEmpleadoNO);
            Controls.Add(label1);
            Controls.Add(btnEliminarPlantilla);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarPlantilla;
        private Label label1;
        private TextBox txtEmpleadoNO;
        private Label lbl2;
        private ListBox lstPlantilla;
    }
}