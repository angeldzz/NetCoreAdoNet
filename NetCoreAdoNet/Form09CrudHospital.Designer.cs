namespace NetCoreAdoNet
{
    partial class Form09CrudHospital
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
            txtHospitalCod = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNum_Cama = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lstHospitales = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // txtHospitalCod
            // 
            txtHospitalCod.Location = new Point(366, 34);
            txtHospitalCod.Name = "txtHospitalCod";
            txtHospitalCod.Size = new Size(100, 23);
            txtHospitalCod.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(366, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(366, 127);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(366, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtNum_Cama
            // 
            txtNum_Cama.Location = new Point(366, 222);
            txtNum_Cama.Name = "txtNum_Cama";
            txtNum_Cama.Size = new Size(100, 23);
            txtNum_Cama.TabIndex = 6;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(366, 265);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(138, 38);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(366, 309);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 39);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.ForeColor = Color.Red;
            btnBorrar.Location = new Point(121, 354);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 38);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 16);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 10;
            label2.Text = "HOSPITAL_COD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 61);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 109);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 12;
            label4.Text = "DIRECCION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 157);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 13;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 204);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 14;
            label6.Text = "Num_CAMA";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(12, 34);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(348, 319);
            lstHospitales.TabIndex = 15;
            // 
            // Form09CrudHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstHospitales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNum_Cama);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtHospitalCod);
            Controls.Add(label1);
            Name = "Form09CrudHospital";
            Text = "Form09CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHospitalCod;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNum_Cama;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnBorrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lstHospitales;
    }
}