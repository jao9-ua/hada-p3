using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENUsuario
    {
        private string nif;
        private string nombre;
        private int edad;

        public string _nif
        {
            get{ return nif; }
            set{ nif = value; }

        }

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int _edad
        {
            get { return edad; }
            set { edad = value; }

        }


        public ENUsuario()
        {
            _nif = "";
            _nombre = "";
            _edad = 0;

        }

        public ENUsuario(string nif, string nombre, int edad)
        {
            _nif = nif;
            _nombre = nombre;
            _edad = edad;

        }

        public bool createUsuario()
        {

            return false;
        }

        public bool readUsuario()
        {
            return false;
        }

        public bool readFirstUsuario()
        {

            return false;
        }

        public bool readNextUsuario()
        {
            return false;
        }

        public bool readPrevUsuario()
        {
            return false;
        }

        public bool updateUsuario()
        {
            return false;
        }

        public bool deleteUsuario()
        {
            return false;
        }
    }
}
