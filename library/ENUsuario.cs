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
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            if (!nuevo.readUsuario(this))
            {
                devolver = nuevo.createUsuario(this);
            }
            return devolver;
        }

        public bool readUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            devolver = nuevo.readUsuario(this);
            return devolver;
        }

        public bool readFirstUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            devolver = nuevo.readFirstUsuario(this);
            return devolver;
        }

        public bool readNextUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            if (nuevo.readUsuario(this))
            {
                devolver = nuevo.readNextUsuario(this);
            }
            return devolver;
        }

        public bool readPrevUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            if (nuevo.readUsuario(this))
            {
                devolver = nuevo.readPrevUsuario(this);
            }
            return devolver;
        }

        public bool updateUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            if (nuevo.readUsuario(this))
            {
                devolver = nuevo.updateUsuario(this);
            }
            return devolver;
        }

        public bool deleteUsuario()
        {
            bool devolver = false;
            CADUsuario nuevo = new CADUsuario();
            if (nuevo.readUsuario(this))
            {
                devolver = nuevo.deleteUsuario(this);
            }
            return devolver;
        }
    }
}
