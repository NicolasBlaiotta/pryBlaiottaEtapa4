namespace pryBlaiottaEtapa4
{
    public partial class Form1 : Form
    {
        ClsVehiculo objVehiculo;

        List<ClsVehiculo> listaVehiculos;
        public Form1()
        {
            InitializeComponent();
            listaVehiculos = new List<ClsVehiculo>();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            ClsVehiculo vehiculo = new ClsVehiculo("Nombre", "Tipo", null);
            vehiculo.crearVehiculo(pctVehiculo, lblNombreVehiculo, lblTipoVehiculo);

            // Listar vehiculo
            listaVehiculos.Add(vehiculo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Limpiar la lista antes de mostrar los vehículos para que no se repitan los previamente listados
            lstVehiculo.Items.Clear();
            // Mostrar todos los vehículos por su nombre
            foreach (ClsVehiculo vehiculo in listaVehiculos)
            {
                lstVehiculo.Items.Add(vehiculo.Nombre);
            }
        }
    }
}