using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            personas nuevaPersona = new personas();
            nuevaPersona.codigo = 120;
            nuevaPersona.nombres = "felipe";
            nuevaPersona.apellidos = "solval ";
            nuevaPersona.direccion = "23y4763487";
            nuevaPersona.telefono = "347658754";
            nuevaPersona.mostrarDatos();

            personas np2 = new personas("1");
            np2.codigo = 130;
            np2.nombres = "julian";
            np2.apellidos = "ortiz";
            np2.direccion = "2do 35";
            np2.telefono = "56123868";
            np2.mostrarDatos();

            personas np3 = new personas();
            np3.codigo = 140;
            np3.nombres = "edilcar";
            np3.apellidos = "solval ";
            np3.direccion = "3ra zona";
            np3.telefono = "4376347";
            np3.mostrarDatos();

            Console.ReadKey();
        }

    }



    /// <summary>
    /// esta clase puede ser utilizada para crear personas con su informacion
    /// como el codigo de nombres, apellidos, direccion
    /// </summary>
    public class personas

    {

        public personas()
        {

        }
        /// <summary>
        /// puede selecionar 1 o 2
        /// </summary>
        /// <param name="tipoPersona"></param>
        public personas(string tipoPersona)



        {



            if (tipoPersona == "1")
            {
                contribuyente_ = "pequeño contribuyente";
            }
            else if (tipoPersona == "2")
            {
                contribuyente_ = "contribuyente normal";

            }
            else
            {
                contribuyente_ = "no asignado";
            }
        }

        private string Universidad_ = "UDEO MAZATE";
        private string contribuyente_;
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string universidad { get { return Universidad_; } }
        public string contribuyente { get { return contribuyente_; } }

        public void mostrarDatos()
        {
            Console.WriteLine();
            Console.WriteLine("codigo:" + codigo + "nombres:" + nombres + "apellido " + apellidos + "dirrecion " + direccion + "telefono" + telefono + "contribuyene" + contribuyente_);
            Console.WriteLine();




        }

    }
}
