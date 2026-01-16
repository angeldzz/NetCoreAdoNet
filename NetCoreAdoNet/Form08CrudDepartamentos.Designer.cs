namespace NetCoreAdoNet
{
    partial class Form08CrudDepartamentos
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
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            btnModificar = new Button();
            btnInsertar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(32, 14);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(88, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 9);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 56);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 100);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Localidad";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(32, 32);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(280, 274);
            lstDepartamentos.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(318, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(318, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(318, 118);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 7;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(318, 194);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 23);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(318, 165);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(109, 23);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Location = new Point(32, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 32);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(btnModificar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstDepartamentos;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button btnModificar;
        private Button btnInsertar;
        private Button btnEliminar;
    }
}