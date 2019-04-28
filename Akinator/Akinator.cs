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
    public partial class Akinator : Form
    {
        //Variables globales
        Random rndColumna = new Random(), rndnacimiento = new Random(), rndcolor = new Random(), rndnumPatas = new Random(),
            rndpeloPlumas = new Random(), rndvoz = new Random();
        DataTable dtnacimiento, dtcolor, dtnumPatas, dtpeloPlumas, dtvoz, dtRespuestas;
        string ramSelectNacimiento="", ramSelectColor="", ramSelectNumPatas="", ramSelectPeloPlumas="", ramSelectVoz="";
        //string ramActualNacimiento = "", ramActualColor = "", ramActualNumPatas = "", ramActualPeloPlumas = "", ramActualVoz = "";
        string _where, respuestaRam, tituloRespuestaRam;

        int[] reduccion = new int[6] {0,0,0,0,0,0};
        //Fin variables globales
    
        public Akinator()   
        {
            InitializeComponent();
        }

        private void Akinator_Load(object sender, EventArgs e)
        {
            buildDataTables();
            preguntasAleatorias();
        }

        private void btnGenerico_click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);

            switch(btn.Text)
            {
                case "Sí":
                    rellenarDeAcuerdoARam();
                    if (dtRespuestas.Rows.Count == 1)
                    {
                        Animal _animal = returnAnimal();
                        AkiResults _resultado = new AkiResults(_animal);
                        _resultado.Show();
                        Hide();
                    }
                    else
                        preguntasAleatorias();
                    break;
                case "No":
                case "No sé":
                    preguntasAleatorias();
                    break;
            }
        }

        void buildDataTables()
        {
            string where = buildWhere();

            dtRespuestas = BDDcomun.GetMySqlTable("SELECT * FROM `ai`.animales" + where + ";");
            dtnacimiento = BDDcomun.GetMySqlTable("SELECT distinct nacimiento from `ai`.animales" + where + ";");
            dtcolor = BDDcomun.GetMySqlTable("SELECT distinct color from `ai`.animales" + where + ";");
            dtnumPatas = BDDcomun.GetMySqlTable("SELECT distinct numPatas from `ai`.animales" + where + ";");
            dtpeloPlumas = BDDcomun.GetMySqlTable("SELECT distinct peloPlumas from `ai`.animales" + where + ";");
            dtvoz = BDDcomun.GetMySqlTable("SELECT distinct voz from `ai`.animales" + where + ";");
        }

        void rellenarDeAcuerdoARam()
        {
            switch (tituloRespuestaRam)
            {
                case "nacimiento":
                    ramSelectNacimiento = respuestaRam;
                    reduccion[1] = ramSelectNacimiento == "" ? 0 : 1;
                    break;
                case "color":
                    ramSelectColor = respuestaRam;
                    reduccion[2] = ramSelectColor == "" ? 0 : 1;
                    break;
                case "numPatas":
                    ramSelectNumPatas = respuestaRam;
                    reduccion[3] = ramSelectNumPatas == "" ? 0 : 1;
                    break;
                case "peloPlumas":
                    ramSelectPeloPlumas = respuestaRam;
                    reduccion[4] = ramSelectPeloPlumas == "" ? 0 : 1;
                    break;
                case "voz":
                    ramSelectVoz = respuestaRam;
                    reduccion[5] = ramSelectVoz == "" ? 0 : 1;
                    break;
            }
            buildDataTables();
        }

        void preguntasAleatorias()
        {
            int opcion = rndColumna.Next(1, 5);
            //Las reducciones son para descartar rapidamente las opciones que no, se tiene que empezar por 
            //la pregunta de la que haya menos respuestas distintas, por ejemplo nacimiento o numero de patas (dos opciones nada mas).
            if (reduccion[1] == 0)
                hacerPregunta(dtnacimiento, ref rndnacimiento, 1);
            else if (reduccion[2] == 0)
                hacerPregunta(dtcolor, ref rndcolor, 2);
            else if (reduccion[5] == 0)
                hacerPregunta(dtvoz, ref rndvoz, 5);  
            else
            {
                if (reduccion[opcion] == 0)
                {
                    switch (opcion)
                    {
                        case 1: preguntasAleatorias(); break;
                        case 2: preguntasAleatorias(); break;
                        case 3: hacerPregunta(dtnumPatas, ref rndnumPatas, opcion); break;
                        case 4: hacerPregunta(dtpeloPlumas, ref rndpeloPlumas, opcion); break;
                        case 5: preguntasAleatorias(); break;
                    }
                }
                else
                    preguntasAleatorias();
            }   
        }

        void hacerPregunta(DataTable dt, ref Random rnd, int opcion)
        {
            int fila = rnd.Next(0, dt.Rows.Count);
            respuestaRam = dt.Rows[fila][0].ToString();
            
            switch(opcion)
            {
                case 1://nacimiento
                    lblPreguntas.Text = "¿Tu animal es " + respuestaRam + "?";
                    tituloRespuestaRam = "nacimiento";
                    break;
                    
                case 2:// color
                    lblPreguntas.Text = "¿Tu animal es de color " + respuestaRam + "?";
                    tituloRespuestaRam = "color";
                    break;

                case 3://numPatas
                    lblPreguntas.Text = "¿Tu animal tiene " + respuestaRam + " patas?";
                    tituloRespuestaRam = "numPatas";
                    break;
                    
                case 4://peloPlumas
                    lblPreguntas.Text = "¿Tu animal tiene " + respuestaRam + "?";
                    tituloRespuestaRam = "peloPlumas";
                    break;

                case 5://voz
                    lblPreguntas.Text = "¿Tu animal " + respuestaRam + "?";
                    tituloRespuestaRam = "voz";
                    break;
            }
        }

        private string buildWhere()
        {
            _where = null;
            _where += ramSelectNacimiento != "" ? " nacimiento = '" + ramSelectNacimiento + "'and" : "";
            _where += ramSelectColor != "" ? " color = '" + ramSelectColor + "'and" : "";
            _where += ramSelectNumPatas != "" ? " numPatas = '" + ramSelectNumPatas + "'and" : "";
            _where += ramSelectPeloPlumas != "" ? " peloPlumas = '" + ramSelectPeloPlumas + "'and" : "";
            _where += ramSelectVoz != "" ? " voz = '" + ramSelectVoz+ "'and" : "";

            _where = _where != "" ? " where " + _where : "";
            _where =  _where != "" ? _where.Substring(0, _where.Length - 3) : "";
            return _where;
         }

        private Animal returnAnimal()
        {
            Animal _animal;
            try
            {
                _animal = new Animal
                (
                    1,
                    dtRespuestas.Rows[0][1].ToString(),
                    dtRespuestas.Rows[0][2].ToString(),
                    dtRespuestas.Rows[0][3].ToString(),
                    dtRespuestas.Rows[0][4].ToString(),
                    dtRespuestas.Rows[0][5].ToString(),
                    dtRespuestas.Rows[0][6].ToString(),
                    dtRespuestas.Rows[0][7].ToString()
                );
                return _animal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
    }
}
