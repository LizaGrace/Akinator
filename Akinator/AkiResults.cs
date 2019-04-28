using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinator
{
    public partial class AkiResults : Form
    {
        Animal animal;
        public AkiResults(Animal _animal)
        {
            animal = _animal;
            InitializeComponent();
        }

        private void AkiResults_Load(object sender, EventArgs e)
        {
            lblNombre.Text += ": " + animal.nombre;
            lblNacimiento.Text += ": " + animal.nacimiento;
            lblColor.Text += ": " + animal.color;
            lblNumPatas.Text += ": " + animal.numPatas;
            lblPiel.Text += ": " + animal.peloPlumas;
            lblVoz.Text += ": " + animal.voz;

            string _string = BDDcomun.GetMySqlString(string.Format("SELECT link FROM `ai`.animales where nombre = '{0}';", animal.nombre));
            pictureBox1.Image = Image.FromFile(_string);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}