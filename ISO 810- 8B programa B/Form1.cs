namespace ISO_810__8B_programa_B
{
    public partial class Form1 : Form
    {
        private readonly string _cedula;
        private readonly string _carpetaImagenes;

        public Form1(string cedula)
        {
            InitializeComponent();

            _cedula = cedula?.Trim() ?? string.Empty;
                        
            _carpetaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "facturas");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCedula.Text = "Cédula: " + (_cedula == string.Empty ? "(no recibida)" : _cedula);

            if (string.IsNullOrWhiteSpace(_cedula))
            {
                MessageBox.Show("No se recibió la cédula como parámetro.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(_carpetaImagenes))
            {
                Directory.CreateDirectory(_carpetaImagenes);
                MessageBox.Show("No se encontraron cheques. Se creó la carpeta:\n" +
                                _carpetaImagenes,
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string rutaJpg = Path.Combine(_carpetaImagenes, _cedula + ".jpg");
            string rutaPng = Path.Combine(_carpetaImagenes, _cedula + ".png");

            string rutaEncontrada = null;

            if (File.Exists(rutaJpg))
                rutaEncontrada = rutaJpg;
            else if (File.Exists(rutaPng))
                rutaEncontrada = rutaPng;

            if (rutaEncontrada == null)
            {
                MessageBox.Show("No se encontró cheque digitalizada para la cédula:\n" + _cedula,
                                "Factura no encontrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                pbCheque.SizeMode = PictureBoxSizeMode.Zoom;
                pbCheque.Image = Image.FromFile(rutaEncontrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el archivo de imagen, pero no se pudo abrir:\n" + ex.Message,
                                "Error al cargar imagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}