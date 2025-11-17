namespace TrabajoEvaluativo_Laboratoria
{
    partial class Form1
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ModifBtn = new System.Windows.Forms.Button();
            this.GridMascota = new System.Windows.Forms.DataGridView();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.RazaLBL = new System.Windows.Forms.Label();
            this.EspecieLBL = new System.Windows.Forms.Label();
            this.NombreDeDueñoLBL = new System.Windows.Forms.Label();
            this.TelefonoLBL = new System.Windows.Forms.Label();
            this.ActivoBTN = new System.Windows.Forms.RadioButton();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.RazaTXT = new System.Windows.Forms.TextBox();
            this.EspecieTXT = new System.Windows.Forms.TextBox();
            this.DueNameTXT = new System.Windows.Forms.TextBox();
            this.TelefonoTXT = new System.Windows.Forms.TextBox();
            this.Visitas = new System.Windows.Forms.Label();
            this.GridVisitas = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.idVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MascotaActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMascotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.AgregarVisita = new System.Windows.Forms.Button();
            this.NombreVisita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagnositcoTxt = new System.Windows.Forms.TextBox();
            this.TratamientoTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NacimentoTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(428, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(243, 55);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Aggregar Mascota";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ModifBtn
            // 
            this.ModifBtn.Location = new System.Drawing.Point(428, 120);
            this.ModifBtn.Name = "ModifBtn";
            this.ModifBtn.Size = new System.Drawing.Size(243, 47);
            this.ModifBtn.TabIndex = 1;
            this.ModifBtn.Text = "Modificar Mascota";
            this.ModifBtn.UseVisualStyleBackColor = true;
            this.ModifBtn.Click += new System.EventHandler(this.ModifBtn_Click);
            // 
            // GridMascota
            // 
            this.GridMascota.AllowUserToOrderColumns = true;
            this.GridMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMascotas,
            this.nombre,
            this.especie,
            this.raza,
            this.fecha,
            this.nombreDue,
            this.telefono,
            this.activo});
            this.GridMascota.Location = new System.Drawing.Point(8, 243);
            this.GridMascota.Name = "GridMascota";
            this.GridMascota.RowHeadersWidth = 51;
            this.GridMascota.RowTemplate.Height = 24;
            this.GridMascota.Size = new System.Drawing.Size(531, 261);
            this.GridMascota.TabIndex = 2;
            this.GridMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMascota_CellContentClick);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(5, 9);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(59, 16);
            this.NombreLbl.TabIndex = 3;
            this.NombreLbl.Text = "Nombre:";
            // 
            // RazaLBL
            // 
            this.RazaLBL.AutoSize = true;
            this.RazaLBL.Location = new System.Drawing.Point(5, 40);
            this.RazaLBL.Name = "RazaLBL";
            this.RazaLBL.Size = new System.Drawing.Size(42, 16);
            this.RazaLBL.TabIndex = 4;
            this.RazaLBL.Text = "Raza:";
            // 
            // EspecieLBL
            // 
            this.EspecieLBL.AutoSize = true;
            this.EspecieLBL.Location = new System.Drawing.Point(5, 68);
            this.EspecieLBL.Name = "EspecieLBL";
            this.EspecieLBL.Size = new System.Drawing.Size(60, 16);
            this.EspecieLBL.TabIndex = 5;
            this.EspecieLBL.Text = "Especie:";
            // 
            // NombreDeDueñoLBL
            // 
            this.NombreDeDueñoLBL.AutoSize = true;
            this.NombreDeDueñoLBL.Location = new System.Drawing.Point(5, 100);
            this.NombreDeDueñoLBL.Name = "NombreDeDueñoLBL";
            this.NombreDeDueñoLBL.Size = new System.Drawing.Size(123, 16);
            this.NombreDeDueñoLBL.TabIndex = 6;
            this.NombreDeDueñoLBL.Text = "Nombre De Dueño:";
            // 
            // TelefonoLBL
            // 
            this.TelefonoLBL.AutoSize = true;
            this.TelefonoLBL.Location = new System.Drawing.Point(5, 132);
            this.TelefonoLBL.Name = "TelefonoLBL";
            this.TelefonoLBL.Size = new System.Drawing.Size(64, 16);
            this.TelefonoLBL.TabIndex = 7;
            this.TelefonoLBL.Text = "Telefono:";
            // 
            // ActivoBTN
            // 
            this.ActivoBTN.AutoSize = true;
            this.ActivoBTN.Location = new System.Drawing.Point(348, 12);
            this.ActivoBTN.Name = "ActivoBTN";
            this.ActivoBTN.Size = new System.Drawing.Size(68, 20);
            this.ActivoBTN.TabIndex = 8;
            this.ActivoBTN.TabStop = true;
            this.ActivoBTN.Text = "Activo:";
            this.ActivoBTN.UseVisualStyleBackColor = true;
            this.ActivoBTN.CheckedChanged += new System.EventHandler(this.ActivoBTN_CheckedChanged);
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(61, 9);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(281, 22);
            this.NombreTXT.TabIndex = 9;
            // 
            // RazaTXT
            // 
            this.RazaTXT.Location = new System.Drawing.Point(53, 37);
            this.RazaTXT.Name = "RazaTXT";
            this.RazaTXT.Size = new System.Drawing.Size(289, 22);
            this.RazaTXT.TabIndex = 10;
            // 
            // EspecieTXT
            // 
            this.EspecieTXT.Location = new System.Drawing.Point(71, 68);
            this.EspecieTXT.Name = "EspecieTXT";
            this.EspecieTXT.Size = new System.Drawing.Size(271, 22);
            this.EspecieTXT.TabIndex = 11;
            // 
            // DueNameTXT
            // 
            this.DueNameTXT.Location = new System.Drawing.Point(134, 97);
            this.DueNameTXT.Name = "DueNameTXT";
            this.DueNameTXT.Size = new System.Drawing.Size(208, 22);
            this.DueNameTXT.TabIndex = 12;
            // 
            // TelefonoTXT
            // 
            this.TelefonoTXT.Location = new System.Drawing.Point(75, 132);
            this.TelefonoTXT.Name = "TelefonoTXT";
            this.TelefonoTXT.Size = new System.Drawing.Size(267, 22);
            this.TelefonoTXT.TabIndex = 13;
            // 
            // Visitas
            // 
            this.Visitas.AutoSize = true;
            this.Visitas.Location = new System.Drawing.Point(677, 4);
            this.Visitas.Name = "Visitas";
            this.Visitas.Size = new System.Drawing.Size(149, 16);
            this.Visitas.TabIndex = 14;
            this.Visitas.Text = "                                  Vicitas";
            this.Visitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GridVisitas
            // 
            this.GridVisitas.AllowUserToOrderColumns = true;
            this.GridVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisita,
            this.nombreMascota,
            this.fechaVisita,
            this.diagnostico,
            this.tratamiento,
            this.MascotaActivo});
            this.GridVisitas.Location = new System.Drawing.Point(545, 243);
            this.GridVisitas.Name = "GridVisitas";
            this.GridVisitas.RowHeadersWidth = 51;
            this.GridVisitas.RowTemplate.Height = 24;
            this.GridVisitas.Size = new System.Drawing.Size(454, 263);
            this.GridVisitas.TabIndex = 15;
            this.GridVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVisitas_CellContentClick);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(448, 173);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(64, 43);
            this.Cargar.TabIndex = 16;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // idVisita
            // 
            this.idVisita.HeaderText = "idVisita";
            this.idVisita.MinimumWidth = 6;
            this.idVisita.Name = "idVisita";
            this.idVisita.Width = 125;
            // 
            // nombreMascota
            // 
            this.nombreMascota.HeaderText = "nombreMascota";
            this.nombreMascota.MinimumWidth = 6;
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Width = 125;
            // 
            // fechaVisita
            // 
            this.fechaVisita.HeaderText = "fechaVisita";
            this.fechaVisita.MinimumWidth = 6;
            this.fechaVisita.Name = "fechaVisita";
            this.fechaVisita.Width = 125;
            // 
            // diagnostico
            // 
            this.diagnostico.HeaderText = "diagnostico";
            this.diagnostico.MinimumWidth = 6;
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.Width = 125;
            // 
            // tratamiento
            // 
            this.tratamiento.HeaderText = "tratamiento";
            this.tratamiento.MinimumWidth = 6;
            this.tratamiento.Name = "tratamiento";
            this.tratamiento.Width = 125;
            // 
            // MascotaActivo
            // 
            this.MascotaActivo.HeaderText = "MascotaActivo";
            this.MascotaActivo.MinimumWidth = 6;
            this.MascotaActivo.Name = "MascotaActivo";
            this.MascotaActivo.Width = 125;
            // 
            // idMascotas
            // 
            this.idMascotas.HeaderText = "id";
            this.idMascotas.MinimumWidth = 6;
            this.idMascotas.Name = "idMascotas";
            this.idMascotas.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // especie
            // 
            this.especie.HeaderText = "especie";
            this.especie.MinimumWidth = 6;
            this.especie.Name = "especie";
            this.especie.Width = 125;
            // 
            // raza
            // 
            this.raza.HeaderText = "Raza";
            this.raza.MinimumWidth = 6;
            this.raza.Name = "raza";
            this.raza.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // nombreDue
            // 
            this.nombreDue.HeaderText = "dueño";
            this.nombreDue.MinimumWidth = 6;
            this.nombreDue.Name = "nombreDue";
            this.nombreDue.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // activo
            // 
            this.activo.HeaderText = "activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.Width = 125;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inactivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(716, 217);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(282, 22);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "ID Mascota";
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // AgregarVisita
            // 
            this.AgregarVisita.Location = new System.Drawing.Point(428, 59);
            this.AgregarVisita.Name = "AgregarVisita";
            this.AgregarVisita.Size = new System.Drawing.Size(243, 55);
            this.AgregarVisita.TabIndex = 19;
            this.AgregarVisita.Text = "Agregar Visita";
            this.AgregarVisita.UseVisualStyleBackColor = true;
            this.AgregarVisita.Click += new System.EventHandler(this.AgregarVisita_Click);
            // 
            // NombreVisita
            // 
            this.NombreVisita.Location = new System.Drawing.Point(677, 20);
            this.NombreVisita.Name = "NombreVisita";
            this.NombreVisita.Size = new System.Drawing.Size(270, 22);
            this.NombreVisita.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Diagnostico:";
            // 
            // DiagnositcoTxt
            // 
            this.DiagnositcoTxt.Location = new System.Drawing.Point(680, 117);
            this.DiagnositcoTxt.Name = "DiagnositcoTxt";
            this.DiagnositcoTxt.Size = new System.Drawing.Size(247, 22);
            this.DiagnositcoTxt.TabIndex = 23;
            // 
            // TratamientoTXT
            // 
            this.TratamientoTXT.Location = new System.Drawing.Point(680, 145);
            this.TratamientoTXT.Name = "TratamientoTXT";
            this.TratamientoTXT.Size = new System.Drawing.Size(247, 22);
            this.TratamientoTXT.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tratamiento:";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(677, 48);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(247, 22);
            this.FechaTxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(575, 173);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(64, 43);
            this.Borrar.TabIndex = 28;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "nacimento:";
            // 
            // NacimentoTXT
            // 
            this.NacimentoTXT.Location = new System.Drawing.Point(83, 162);
            this.NacimentoTXT.Name = "NacimentoTXT";
            this.NacimentoTXT.Size = new System.Drawing.Size(267, 22);
            this.NacimentoTXT.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 544);
            this.Controls.Add(this.NacimentoTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.FechaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TratamientoTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiagnositcoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreVisita);
            this.Controls.Add(this.AgregarVisita);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.GridVisitas);
            this.Controls.Add(this.Visitas);
            this.Controls.Add(this.TelefonoTXT);
            this.Controls.Add(this.DueNameTXT);
            this.Controls.Add(this.EspecieTXT);
            this.Controls.Add(this.RazaTXT);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.ActivoBTN);
            this.Controls.Add(this.TelefonoLBL);
            this.Controls.Add(this.NombreDeDueñoLBL);
            this.Controls.Add(this.EspecieLBL);
            this.Controls.Add(this.RazaLBL);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.GridMascota);
            this.Controls.Add(this.ModifBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ModifBtn;
        private System.Windows.Forms.DataGridView GridMascota;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label RazaLBL;
        private System.Windows.Forms.Label EspecieLBL;
        private System.Windows.Forms.Label NombreDeDueñoLBL;
        private System.Windows.Forms.Label TelefonoLBL;
        private System.Windows.Forms.RadioButton ActivoBTN;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.TextBox RazaTXT;
        private System.Windows.Forms.TextBox EspecieTXT;
        private System.Windows.Forms.TextBox DueNameTXT;
        private System.Windows.Forms.TextBox TelefonoTXT;
        private System.Windows.Forms.Label Visitas;
        private System.Windows.Forms.DataGridView GridVisitas;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MascotaActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Button AgregarVisita;
        private System.Windows.Forms.TextBox NombreVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiagnositcoTxt;
        private System.Windows.Forms.TextBox TratamientoTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NacimentoTXT;
    }
}

