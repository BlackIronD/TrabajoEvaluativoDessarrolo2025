using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TrabajoEvaluativo_Laboratoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActivoBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGridMascota();
            cargarMascotas();

            ConfigurarGridVisitas();
            cargarVisitas();
        }
        
            public void cargarMascotas()
        {
            GridMascota.Rows.Clear();

            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";
            string consulta = "SELECT idMascotas, nombre, especie, raza, fechaNac, nombreDue, telefono, activo FROM mascotas;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["idMascotas"]);
                        string nombre = dr["nombre"] == DBNull.Value ? "" : dr["nombre"].ToString();
                        string especie = dr["especie"] == DBNull.Value ? "" : dr["especie"].ToString();
                        string raza = dr["raza"] == DBNull.Value ? "" : dr["raza"].ToString();
                        string fecha = dr["fechaNac"] == DBNull.Value ? "" : Convert.ToDateTime(dr["fechaNac"]).ToString("yyyy-MM-dd");
                        string duenio = dr["nombreDue"] == DBNull.Value ? "" : dr["nombreDue"].ToString();
                        string telefono = dr["telefono"] == DBNull.Value ? "" : dr["telefono"].ToString();
                        int activo = Convert.ToInt32(dr["activo"]);

                        GridMascota.Rows.Add(
                            id.ToString(),
                            nombre,
                            especie,
                            raza,
                            fecha,
                            duenio,
                            telefono,
                            activo.ToString()
                        );
                    }
                }
            }

            GridMascota.ClearSelection();
        }
        public void cargarVisitas()
        {
            GridVisitas.Rows.Clear();

            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";

            // JOIN con la tabla mascotas para mostrar nombre
            string consulta = @"
        SELECT v.idVisita, m.nombre AS nombreMascota, v.fecha, v.diagnostico, v.tratamiento, v.activo
        FROM visita v
        INNER JOIN mascotas m ON v.idMascotas = m.idMascotas;
    ";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["idVisita"]);
                        string nombreMascota = dr["nombreMascota"] == DBNull.Value ? "" : dr["nombreMascota"].ToString();
                        var mysqlFecha = dr.GetMySqlDateTime("fecha");
                        string fecha = mysqlFecha.IsValidDateTime ? mysqlFecha.GetDateTime().ToString("yyyy-MM-dd") : "";

                        string diagnostico = dr["diagnostico"] == DBNull.Value ? "" : dr["diagnostico"].ToString();
                        string tratamiento = dr["tratamiento"] == DBNull.Value ? "" : dr["tratamiento"].ToString();
                        int activo = Convert.ToInt32(dr["activo"]);

                        GridVisitas.Rows.Add(
                            id.ToString(),
                            nombreMascota,
                            fecha,
                            diagnostico,
                            tratamiento,
                            activo.ToString()
                        );
                    }
                }
            }

            GridVisitas.ClearSelection();
        }





        private void AddBtn_Click(object sender, EventArgs e)
        {
            string nombre = NombreTXT.Text.Trim();
            string raza = RazaTXT.Text.Trim();
            string especie = EspecieTXT.Text.Trim();
            string duenio = DueNameTXT.Text.Trim();
            string telefono = TelefonoTXT.Text.Trim();
            int activo = ActivoBTN.Checked ? 1 : 0;

            
            string fechaTexto = DiagnositcoTxt.Text ?? "";
            fechaTexto = fechaTexto.Trim();
           
            DateTime fechaNac;
            string[] formatos = new[]
            {
        "yyyy-MM-dd",
        "yyyy-MM-dd HH:mm:ss",
        "yyyy-MM-ddTHH:mm:ss", 
        "dd/MM/yyyy",
        "d/M/yyyy",
        "dd-MM-yyyy",
        "yyyy/MM/dd",
        "M/d/yyyy",
        "yyyyMMdd"
    };
            if (DateTime.TryParseExact(fechaTexto, formatos, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out fechaNac))
            {
                // ok
            }
            
           
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre de la mascota es obligatorio.");
                return;
            }

            
            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";
            string consulta = @"
        INSERT INTO mascotas (nombre, especie, raza, fechaNac, nombreDue, telefono, activo)
        VALUES (@nombre, @especie, @raza, @fechaNac, @nombreDue, @telefono, @activo);
    ";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@raza", raza);

                   
                    cmd.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = fechaNac.Date;

                    cmd.Parameters.AddWithValue("@nombreDue", duenio);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@activo", activo);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mascota agregada correctamente.");
                        cargarMascotas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la mascota.");
                    }

                 
                    NombreTXT.Text = string.Empty;
                    RazaTXT.Text = string.Empty;
                    EspecieTXT.Text = string.Empty;
                    DiagnositcoTxt.Text = string.Empty;
                    DueNameTXT.Text = string.Empty;
                    TelefonoTXT.Text = string.Empty;
                    ActivoBTN.Checked = false;
                }
            }
        }
        
        private void FiltrarVisitas(string texto)
        {
            GridVisitas.Rows.Clear();

            if (string.IsNullOrEmpty(texto))
            {
                // Si el texto está vacío, cargamos todas las visitas
                cargarVisitas();
                return;
            }

            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";

            // Seleccionamos solo las visitas cuya mascota coincide con el nombre o el ID
            string consulta = @"
        SELECT v.idVisita, m.nombre AS nombreMascota, v.fecha, v.diagnostico, v.tratamiento, v.activo
        FROM visita v
        INNER JOIN mascotas m ON v.idMascotas = m.idMascotas
        WHERE m.nombre LIKE @texto OR v.idMascotas = @id;
    ";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    int idBuscado;
                    if (!int.TryParse(texto, out idBuscado))
                        idBuscado = -1; // Si no es número, usamos un ID imposible
                    cmd.Parameters.AddWithValue("@id", idBuscado);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["idVisita"]);
                            string nombreMascota = dr["nombreMascota"] == DBNull.Value ? "" : dr["nombreMascota"].ToString();
                            string fecha = dr["fecha"] == DBNull.Value ? "" : Convert.ToDateTime(dr["fecha"]).ToString("yyyy-MM-dd");
                            string diagnostico = dr["diagnostico"] == DBNull.Value ? "" : dr["diagnostico"].ToString();
                            string tratamiento = dr["tratamiento"] == DBNull.Value ? "" : dr["tratamiento"].ToString();
                            int activo = Convert.ToInt32(dr["activo"]);

                            GridVisitas.Rows.Add(
                                id.ToString(),
                                nombreMascota,
                                fecha,
                                diagnostico,
                                tratamiento,
                                activo.ToString()
                            );
                        }
                    }
                }
            }

            GridVisitas.ClearSelection();
        }

        private void ModifBtn_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                MessageBox.Show("Selecciona primero una mascota.");
                return;
            }

            int idMascota = Convert.ToInt32(this.Tag);
            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";

            string consulta = @"
        UPDATE mascotas
        SET nombre = @nombre,
            raza = @raza,
            especie = @especie,
            fechaNac = @fechaNac,
            nombreDue = @nombreDue,
            telefono = @telefono,
            activo = @activo
        WHERE idMascotas = @id;
    ";

            // Validar fecha
            DateTime fechaNac;
            if (!DateTime.TryParse(DiagnositcoTxt.Text.Trim(), out fechaNac))
            {
                MessageBox.Show("Fecha de nacimiento inválida. Usa formato yyyy-MM-dd.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", NombreTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@raza", RazaTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@especie", EspecieTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@fechaNac", fechaNac.ToString(""));
                    cmd.Parameters.AddWithValue("@nombreDue", DueNameTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", TelefonoTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@activo", ActivoBTN.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", idMascota);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mascota modificada correctamente.");
                        cargarMascotas(); // Recarga el grid para reflejar cambios
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la mascota.");
                    }

                    // Limpiar TextBox y RadioButton
                    NombreTXT.Text = string.Empty;
                    RazaTXT.Text = string.Empty;
                    EspecieTXT.Text = string.Empty;
                    DiagnositcoTxt.Text = string.Empty;
                    DueNameTXT.Text = string.Empty;
                    TelefonoTXT.Text = string.Empty;
                    ActivoBTN.Checked = false;

                    // Limpiar el Tag
                    this.Tag = null;
                }
            }

        }

        private void GridVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = GridMascota.Rows[e.RowIndex];

            NombreTXT.Text = fila.Cells["nombre"].Value.ToString();
            RazaTXT.Text = fila.Cells["raza"].Value.ToString();
            EspecieTXT.Text = fila.Cells["especie"].Value.ToString();
            DueNameTXT.Text = fila.Cells["nombreDue"].Value.ToString();
            TelefonoTXT.Text = fila.Cells["telefono"].Value.ToString();

            int activo = Convert.ToInt32(fila.Cells["activo"].Value);
            ActivoBTN.Checked = activo == 1;

            this.Tag = fila.Cells["idMascotas"].Value;
        }

        

        private void Cargar_Click(object sender, EventArgs e)
        {
            GridMascota.Columns.Clear();
            GridMascota.AutoGenerateColumns = false;

            GridMascota.Columns.Add("idMascotas", "ID");
            GridMascota.Columns.Add("nombre", "Nombre");
            GridMascota.Columns.Add("especie", "Especie");
            GridMascota.Columns.Add("raza", "Raza");
            GridMascota.Columns.Add("fechaNac", "Fecha Nac");
            GridMascota.Columns.Add("nombreDue", "Nombre Dueño");
            GridMascota.Columns.Add("telefono", "Teléfono");
            GridMascota.Columns.Add("activo", "Activo");
            cargarMascotas();

            GridVisitas.Columns.Clear();
            GridVisitas.AutoGenerateColumns = false;

            GridVisitas.Columns.Add("idVisita", "ID");
            GridVisitas.Columns.Add("nombreMascota", "Nombre Mascota");
            GridVisitas.Columns.Add("fecha", "Fecha");
            GridVisitas.Columns.Add("diagnostico", "Diagnóstico");
            GridVisitas.Columns.Add("tratamiento", "Tratamiento");
            GridVisitas.Columns.Add("activo", "Activo");

            cargarVisitas();
        }
        private void ConfigurarGridMascota()
        {
            GridMascota.Columns.Clear();
            GridMascota.AutoGenerateColumns = false;

            GridMascota.Columns.Add("idMascotas", "ID");
            GridMascota.Columns.Add("nombre", "Nombre");
            GridMascota.Columns.Add("especie", "Especie");
            GridMascota.Columns.Add("raza", "Raza");
            GridMascota.Columns.Add("fechaNac", "Fecha Nac");
            GridMascota.Columns.Add("nombreDue", "Nombre Dueño");
            GridMascota.Columns.Add("telefono", "Teléfono");
            GridMascota.Columns.Add("activo", "Activo");
        }

        private void ConfigurarGridVisitas()
        {
            GridVisitas.Columns.Clear();
            GridVisitas.AutoGenerateColumns = false;

            GridVisitas.Columns.Add("idVisita", "ID");
            GridVisitas.Columns.Add("nombreMascota", "Nombre Mascota");
            GridVisitas.Columns.Add("fecha", "Fecha");
            GridVisitas.Columns.Add("diagnostico", "Diagnóstico");
            GridVisitas.Columns.Add("tratamiento", "Tratamiento");
            GridVisitas.Columns.Add("activo", "Activo");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {

            FiltrarVisitas(Buscar.Text.Trim());

        }

        private void AgregarVisita_Click(object sender, EventArgs e)
        {
            // Validamos que haya un ID de mascota seleccionado
            if (this.Tag == null)
            {
                MessageBox.Show("Selecciona primero una mascota para asignarle la visita.");
                return;
            }

            int idMascota = Convert.ToInt32(this.Tag);

            string nombre = NombreVisita.Text.Trim();
            string fecha = FechaTxt.Text.Trim(); // formato: yyyy-MM-dd
            string diagnostico = DiagnositcoTxt.Text.Trim();
            string tratamiento = TratamientoTXT.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("Nombre de la visita y fecha son obligatorios.");
                return;
            }

            string conexion = "Server=localhost;User ID=root;Password=;Database=veterinaria_db";

            string consulta = @"
        INSERT INTO visita (idMascotas, fecha, diagnostico, tratamiento, activo)
        VALUES (@idMascota, @fecha, @diagnostico, @tratamiento, @activo);
    ";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@idMascota", idMascota);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    cmd.Parameters.AddWithValue("@activo", 1); // siempre activa al agregar

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Visita agregada correctamente.");
                        cargarVisitas(); // Recarga el grid para reflejar cambios
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la visita.");
                    }

                    // Limpiar TextBox
                    NombreVisita.Text = string.Empty;
                    FechaTxt.Text = string.Empty;
                    DiagnositcoTxt.Text = string.Empty;
                    TratamientoTXT.Text = string.Empty;
                }
            }
        }
    }
}

