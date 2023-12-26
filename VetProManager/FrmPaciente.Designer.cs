namespace VetProManager
{
    partial class FrmPaciente
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
            txtNombrePaciente = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblNombrePaciente = new Label();
            lblFechaNacimientoPaciente = new Label();
            txtNombreDueño = new TextBox();
            txtDniDueño = new TextBox();
            lblNombreDueño = new Label();
            lblDniDueño = new Label();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            txtHistorial = new TextBox();
            lblHistorial = new Label();
            txtNumeroContacto = new TextBox();
            lblNumeroContacto = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            grpResponsableRegistrado = new GroupBox();
            rdoDueñoNoRegistrado = new RadioButton();
            rdoDueñoRegistrado = new RadioButton();
            label1 = new Label();
            txtApellidoDueño = new TextBox();
            txtEspecie = new TextBox();
            lblEspecie = new Label();
            grpResponsableRegistrado.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(59, 294);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(256, 23);
            txtNombrePaciente.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(59, 384);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(256, 23);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombrePaciente.Location = new Point(59, 276);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(135, 17);
            lblNombrePaciente.TabIndex = 2;
            lblNombrePaciente.Text = "Nombre del paciente:";
            // 
            // lblFechaNacimientoPaciente
            // 
            lblFechaNacimientoPaciente.AutoSize = true;
            lblFechaNacimientoPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimientoPaciente.Location = new Point(59, 364);
            lblFechaNacimientoPaciente.Name = "lblFechaNacimientoPaciente";
            lblFechaNacimientoPaciente.Size = new Size(205, 17);
            lblFechaNacimientoPaciente.TabIndex = 3;
            lblFechaNacimientoPaciente.Text = "Fecha de nacimiento del paciente:";
            // 
            // txtNombreDueño
            // 
            txtNombreDueño.Location = new Point(59, 120);
            txtNombreDueño.Name = "txtNombreDueño";
            txtNombreDueño.Size = new Size(256, 23);
            txtNombreDueño.TabIndex = 2;
            // 
            // txtDniDueño
            // 
            txtDniDueño.Location = new Point(59, 250);
            txtDniDueño.Name = "txtDniDueño";
            txtDniDueño.Size = new Size(256, 23);
            txtDniDueño.TabIndex = 5;
            // 
            // lblNombreDueño
            // 
            lblNombreDueño.AutoSize = true;
            lblNombreDueño.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreDueño.Location = new Point(59, 100);
            lblNombreDueño.Name = "lblNombreDueño";
            lblNombreDueño.Size = new Size(123, 17);
            lblNombreDueño.TabIndex = 6;
            lblNombreDueño.Text = "Nombre del dueño:";
            // 
            // lblDniDueño
            // 
            lblDniDueño.AutoSize = true;
            lblDniDueño.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniDueño.Location = new Point(59, 232);
            lblDniDueño.Name = "lblDniDueño";
            lblDniDueño.Size = new Size(96, 17);
            lblDniDueño.TabIndex = 7;
            lblDniDueño.Text = "DNI del dueño:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(399, 44);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(389, 53);
            txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblObservaciones.Location = new Point(399, 21);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(97, 17);
            lblObservaciones.TabIndex = 9;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(399, 120);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(389, 287);
            txtHistorial.TabIndex = 10;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(399, 100);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(59, 17);
            lblHistorial.TabIndex = 11;
            lblHistorial.Text = "Historial:";
            // 
            // txtNumeroContacto
            // 
            txtNumeroContacto.Location = new Point(59, 206);
            txtNumeroContacto.Name = "txtNumeroContacto";
            txtNumeroContacto.Size = new Size(256, 23);
            txtNumeroContacto.TabIndex = 4;
            // 
            // lblNumeroContacto
            // 
            lblNumeroContacto.AutoSize = true;
            lblNumeroContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroContacto.Location = new Point(59, 188);
            lblNumeroContacto.Name = "lblNumeroContacto";
            lblNumeroContacto.Size = new Size(132, 17);
            lblNumeroContacto.TabIndex = 13;
            lblNumeroContacto.Text = "Número de contacto:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LimeGreen;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(243, 466);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(134, 64);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(475, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 64);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // grpResponsableRegistrado
            // 
            grpResponsableRegistrado.Controls.Add(rdoDueñoNoRegistrado);
            grpResponsableRegistrado.Controls.Add(rdoDueñoRegistrado);
            grpResponsableRegistrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpResponsableRegistrado.Location = new Point(59, 21);
            grpResponsableRegistrado.Name = "grpResponsableRegistrado";
            grpResponsableRegistrado.Size = new Size(256, 76);
            grpResponsableRegistrado.TabIndex = 16;
            grpResponsableRegistrado.TabStop = false;
            grpResponsableRegistrado.Text = "¿El dueño ya está registrado?";
            // 
            // rdoDueñoNoRegistrado
            // 
            rdoDueñoNoRegistrado.AutoSize = true;
            rdoDueñoNoRegistrado.Checked = true;
            rdoDueñoNoRegistrado.Location = new Point(161, 33);
            rdoDueñoNoRegistrado.Name = "rdoDueñoNoRegistrado";
            rdoDueñoNoRegistrado.Size = new Size(44, 21);
            rdoDueñoNoRegistrado.TabIndex = 1;
            rdoDueñoNoRegistrado.TabStop = true;
            rdoDueñoNoRegistrado.Text = "No";
            rdoDueñoNoRegistrado.UseVisualStyleBackColor = true;
            rdoDueñoNoRegistrado.CheckedChanged += rdoDueñoNoRegistrado_CheckedChanged;
            // 
            // rdoDueñoRegistrado
            // 
            rdoDueñoRegistrado.AutoSize = true;
            rdoDueñoRegistrado.Location = new Point(60, 33);
            rdoDueñoRegistrado.Name = "rdoDueñoRegistrado";
            rdoDueñoRegistrado.Size = new Size(36, 21);
            rdoDueñoRegistrado.TabIndex = 0;
            rdoDueñoRegistrado.Text = "Si";
            rdoDueñoRegistrado.UseVisualStyleBackColor = true;
            rdoDueñoRegistrado.CheckedChanged += rdoDueñoRegistrado_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 144);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 17;
            label1.Text = "Apellido de dueño:";
            // 
            // txtApellidoDueño
            // 
            txtApellidoDueño.Location = new Point(59, 162);
            txtApellidoDueño.Name = "txtApellidoDueño";
            txtApellidoDueño.Size = new Size(256, 23);
            txtApellidoDueño.TabIndex = 3;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(59, 338);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(256, 23);
            txtEspecie.TabIndex = 7;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecie.Location = new Point(59, 320);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(55, 17);
            lblEspecie.TabIndex = 22;
            lblEspecie.Text = "Especie:";
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(846, 542);
            Controls.Add(lblEspecie);
            Controls.Add(txtEspecie);
            Controls.Add(txtApellidoDueño);
            Controls.Add(label1);
            Controls.Add(grpResponsableRegistrado);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblNumeroContacto);
            Controls.Add(txtNumeroContacto);
            Controls.Add(lblHistorial);
            Controls.Add(txtHistorial);
            Controls.Add(lblObservaciones);
            Controls.Add(txtObservaciones);
            Controls.Add(lblDniDueño);
            Controls.Add(lblNombreDueño);
            Controls.Add(txtDniDueño);
            Controls.Add(txtNombreDueño);
            Controls.Add(lblFechaNacimientoPaciente);
            Controls.Add(lblNombrePaciente);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombrePaciente);
            Name = "FrmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del paciente";
            grpResponsableRegistrado.ResumeLayout(false);
            grpResponsableRegistrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePaciente;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblNombrePaciente;
        private Label lblFechaNacimientoPaciente;
        private TextBox txtNombreDueño;
        private TextBox txtDniDueño;
        private Label lblNombreDueño;
        private Label lblDniDueño;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private TextBox txtHistorial;
        private Label lblHistorial;
        private TextBox txtNumeroContacto;
        private Label lblNumeroContacto;
        private Button btnAceptar;
        private Button btnCancelar;
        private GroupBox grpResponsableRegistrado;
        private RadioButton rdoDueñoNoRegistrado;
        private RadioButton rdoDueñoRegistrado;
        private Label label1;
        private TextBox txtApellidoDueño;
        private TextBox txtEspecie;
        private Label lblEspecie;
    }
}