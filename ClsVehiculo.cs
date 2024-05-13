using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBlaiottaEtapa4
{
    internal class ClsVehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        public ClsVehiculo(string nombre, string tipo, Image imagen)
        {
            Nombre = nombre;
            Tipo = tipo;
            Imagen = imagen;
        }
        public void crearVehiculo(PictureBox pctVehiculo, Label nombre, Label tipo)
        {
            PictureBox vehiculo = new PictureBox();
            Random rnd = new Random();
            switch (rnd.Next(1, 4))
            {
                case 1:
                    Nombre = "Peugeot";
                    Tipo = "Auto";
                    Imagen = pryBlaiottaEtapa4.Properties.Resources.auto;
                    break;
                case 2:
                    Nombre = "Bayliner";
                    Tipo = "Barco";
                    Imagen = pryBlaiottaEtapa4.Properties.Resources.barco;
                    break;
                case 3:
                    Nombre = "Iberia";
                    Tipo = "Avion";
                    Imagen = pryBlaiottaEtapa4.Properties.Resources.avion;
                    break;
            }
            vehiculo.Image = Imagen;
            vehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            vehiculo.Location = pctVehiculo.Location;
            vehiculo.Size = pctVehiculo.Size;

            pctVehiculo.Parent.Controls.Add(vehiculo);
            vehiculo.BringToFront();
            nombre.Text = Nombre;
            tipo.Text = Tipo;
        }
    }
}