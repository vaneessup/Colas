using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.clases
{
    //crear clase paciente
    class Pacientes
    {
        string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string nombrep;

        public string Nombre
        {
            get { return nombrep; }
            set { nombrep = value; }
        }

        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }



        //metodos

        public void ingresarDatos()
        {
            Console.WriteLine("\nIngrese el codigo del paciente: ");
            codigo = Console.ReadLine();
            Console.WriteLine("\nIngrese el nombre del paciente: ");
            nombrep = Console.ReadLine();
            Console.WriteLine("\nIngrese el apellido del paciente: ");
            apellido = Console.ReadLine();
            Console.WriteLine("\nIngrese el estado del paciente: ");
            estado = Console.ReadLine();
        }

        struct cola
        {
            string codigo1;
            string nombre1;
            string apellido1;
            string estado;

        };

        cola colaCreate()
        {
            cola cola1;
            cola1.ToString().codigo1 = -1;
            return cola1;

        }

        
    }

    
}
