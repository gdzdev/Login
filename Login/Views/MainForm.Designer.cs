namespace Login.Views
{
    partial class MainForm
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
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDepartamento = new ComboBox();
            txtNombre = new TextBox();
            txtSalario = new TextBox();
            txtEdad = new TextBox();
            label6 = new Label();
            txtBuscar = new TextBox();
            rgvEmpleados = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 0;
            label3.Text = "HANES BRANDS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 505);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 466);
            button1.Name = "button1";
            button1.Size = new Size(158, 27);
            button1.TabIndex = 6;
            button1.Text = "CERRAR SESION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCerrarSesion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 51);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(12, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 51);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(12, 221);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(158, 51);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(12, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 51);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(12, 77);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 51);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 3;
            label2.Text = "Salario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(514, 107);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(263, 163);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 5;
            label5.Text = "Departamento:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Enabled = false;
            cmbDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(394, 155);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(266, 29);
            cmbDepartamento.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(346, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(409, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtSalario
            // 
            txtSalario.Enabled = false;
            txtSalario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(346, 104);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(162, 29);
            txtSalario.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(572, 104);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(183, 29);
            txtEdad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(263, 251);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 10;
            label6.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(334, 243);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(421, 29);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // rgvEmpleados
            // 
            rgvEmpleados.AllowUserToAddRows = false;
            rgvEmpleados.AllowUserToDeleteRows = false;
            rgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rgvEmpleados.Location = new Point(236, 321);
            rgvEmpleados.Name = "rgvEmpleados";
            rgvEmpleados.ReadOnly = true;
            rgvEmpleados.Size = new Size(552, 150);
            rgvEmpleados.TabIndex = 12;
            rgvEmpleados.CellClick += rgvEmpleados_CellClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(rgvEmpleados);
            Controls.Add(txtBuscar);
            Controls.Add(label6);
            Controls.Add(txtEdad);
            Controls.Add(txtSalario);
            Controls.Add(txtNombre);
            Controls.Add(cmbDepartamento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox cmbDepartamento;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private TextBox txtEdad;
        private Label label6;
        private TextBox txtBuscar;
        private DataGridView rgvEmpleados;
        private Button button1;
    }
}