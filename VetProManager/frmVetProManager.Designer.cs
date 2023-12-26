namespace VetProManager
{
    partial class FrmVetProManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVerHistorial = new Button();
            lblLista = new Label();
            btnInformacionDetallada = new Button();
            btnVerRegistroPersonas = new Button();
            dgvPacientes = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombrePaciente = new DataGridViewTextBoxColumn();
            especie = new DataGridViewTextBoxColumn();
            fechaIngreso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(815, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 53);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "✔ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(817, 113);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 53);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "✏ Modificar / Agregar historial";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(817, 172);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "❌ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.BackColor = Color.MediumOrchid;
            btnVerHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerHistorial.ForeColor = Color.White;
            btnVerHistorial.Location = new Point(815, 340);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(134, 53);
            btnVerHistorial.TabIndex = 4;
            btnVerHistorial.Text = "Ver historial";
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLista.Location = new Point(28, 22);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(196, 25);
            lblLista.TabIndex = 7;
            lblLista.Text = "Listado de pacientes:";
            // 
            // btnInformacionDetallada
            // 
            btnInformacionDetallada.BackColor = Color.MediumOrchid;
            btnInformacionDetallada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformacionDetallada.ForeColor = Color.White;
            btnInformacionDetallada.Location = new Point(815, 399);
            btnInformacionDetallada.Name = "btnInformacionDetallada";
            btnInformacionDetallada.Size = new Size(136, 53);
            btnInformacionDetallada.TabIndex = 5;
            btnInformacionDetallada.Text = "Ver información detallada";
            btnInformacionDetallada.UseVisualStyleBackColor = false;
            btnInformacionDetallada.Click += btnInformacionDetallada_Click;
            // 
            // btnVerRegistroPersonas
            // 
            btnVerRegistroPersonas.BackColor = Color.MediumOrchid;
            btnVerRegistroPersonas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerRegistroPersonas.ForeColor = Color.White;
            btnVerRegistroPersonas.Location = new Point(815, 458);
            btnVerRegistroPersonas.Name = "btnVerRegistroPersonas";
            btnVerRegistroPersonas.Size = new Size(134, 50);
            btnVerRegistroPersonas.TabIndex = 6;
            btnVerRegistroPersonas.Text = "Ver personas registradas";
            btnVerRegistroPersonas.UseVisualStyleBackColor = false;
            btnVerRegistroPersonas.Click += btnVerRegistroPersonas_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.BackgroundColor = Color.PaleTurquoise;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeight = 30;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { id, nombrePaciente, especie, fechaIngreso });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(28, 54);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowTemplate.Height = 26;
            dgvPacientes.ScrollBars = ScrollBars.Vertical;
            dgvPacientes.Size = new Size(754, 454);
            dgvPacientes.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 40;
            // 
            // nombrePaciente
            // 
            nombrePaciente.HeaderText = "Nombre del paciente";
            nombrePaciente.Name = "nombrePaciente";
            nombrePaciente.ReadOnly = true;
            nombrePaciente.Width = 238;
            // 
            // especie
            // 
            especie.HeaderText = "Especie";
            especie.Name = "especie";
            especie.ReadOnly = true;
            especie.Width = 238;
            // 
            // fechaIngreso
            // 
            fechaIngreso.HeaderText = "Fecha de ingreso";
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.ReadOnly = true;
            fechaIngreso.Width = 238;
            // 
            // FrmVetProManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(978, 553);
            Controls.Add(dgvPacientes);
            Controls.Add(btnVerRegistroPersonas);
            Controls.Add(btnInformacionDetallada);
            Controls.Add(lblLista);
            Controls.Add(btnVerHistorial);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmVetProManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetProManager";
            FormClosing += FrmVetProManager_FormClosing;
            Load += FrmVetProManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVerHistorial;
        private Label lblLista;
        private Button btnInformacionDetallada;
        private Button btnVerRegistroPersonas;
        private DataGridView dgvPacientes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombrePaciente;
        private DataGridViewTextBoxColumn especie;
        private DataGridViewTextBoxColumn fechaIngreso;
    }
}