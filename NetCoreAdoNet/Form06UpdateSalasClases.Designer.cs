namespace NetCoreAdoNet
{
    partial class Form06UpdateSalasClases
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
            txtNuevoNombre = new TextBox();
            label2 = new Label();
            btnUpdateSalas = new Button();
            lstSalas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(265, 37);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(140, 23);
            txtNuevoNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 10);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 8;
            label2.Text = "Nuevo Nombre";
            // 
            // btnUpdateSalas
            // 
            btnUpdateSalas.Location = new Point(265, 66);
            btnUpdateSalas.Name = "btnUpdateSalas";
            btnUpdateSalas.Size = new Size(140, 32);
            btnUpdateSalas.TabIndex = 7;
            btnUpdateSalas.Text = "Update Salas";
            btnUpdateSalas.UseVisualStyleBackColor = true;
            btnUpdateSalas.Click += btnUpdateSalas_Click;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(12, 28);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(217, 274);
            lstSalas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label2);
            Controls.Add(btnUpdateSalas);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevoNombre;
        private Label label2;
        private Button btnUpdateSalas;
        private ListBox lstSalas;
        private Label label1;
    }
}