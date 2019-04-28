using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinator
{
    public class Animal
    {
        public int id;
        public string nombre;
        public string nacimiento;
        public string color;
        public string numPatas;
        public string peloPlumas;
        public string voz;
        public string link;

        public Animal()
        {

        }
        public Animal(int _id, string _nombre, string _nacimiento, string _color, string _numPatas, string _peloPlumas, string _voz, string _link)
        {
            id = _id;
            nombre = _nombre;
            nacimiento = _nacimiento;
            color = _color;
            numPatas = _numPatas;
            peloPlumas = _peloPlumas;
            voz = _voz;
            link = _link;
        }

        
    }
}
