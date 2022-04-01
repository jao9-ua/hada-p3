using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace library
{
    class CADUsuario
    {
        private string constring;


        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();

        }

        public bool createUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("Insert INTO [dbo].[Usuarios] (nombre, nif, edad) VALUES ('" + en._nombre + "', '" + en._nif + "', " + en._edad + ")");
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }

            return devolver;
        }

        public bool readUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("Select * from [dbo].[Usuarios] Where nif ='" + en._nif + "' ", conexion);
                SqlDataReader buscar = com.ExecuteReader();
                buscar.Read();

                if (buscar["nif"].ToString() == en._nif)
                {
                    en._nif = buscar["nif"].ToString();
                    en._nombre = buscar["nombre"].ToString();
                    en._edad = int.Parse(buscar["edad"].ToString());
                }
                else
                {
                    devolver = false;
                }

                buscar.Close();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);

            }
            return devolver;
        }

        public bool readFirstUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("Select * From [dbo].[Usuarios]", conexion);
                SqlDataReader buscar = com.ExecuteReader();

                buscar.Read();
                en._nif = buscar["nif"].ToString();
                en._nombre = buscar["nombre"].ToString();
                en._edad = int.Parse(buscar["edad"].ToString());

                devolver = true;
                buscar.Close();
                conexion.Close();

            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);
            }

            return devolver;
        }

        public bool readNextUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("Select * From [dbo].[Usuarios]", conexion);
                SqlDataReader buscar = com.ExecuteReader();

                while (buscar.Read())
                {
                    if (en._nif.ToString() == buscar["nif"].ToString())
                    {
                        en._nif = buscar["nif"].ToString();
                        en._nombre = buscar["nombre"].ToString();
                        en._edad = int.Parse(buscar["edad"].ToString());
                        break;
                    }
                }

                devolver = true;
                buscar.Close();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);
            }

            return devolver;
        }

        public bool readPrevUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("Select * From [dbo].[Usuarios]", conexion);
                SqlDataReader buscar = com.ExecuteReader();
                buscar.Read();
                ENUsuario resp = new ENUsuario();

               
                

                while (buscar.Read()) {


                    resp._nombre = buscar["nombre"].ToString();
                    resp._nif = buscar["nif"].ToString();
                    resp._edad = int.Parse(buscar["edad"].ToString());
                    if(buscar["nif"].ToString() == en._nif)
                    {
                        break;
                    }                
                }
                en._nif = resp._nif;
                en._nombre = resp._nombre;
                en._edad = resp._edad;

                buscar.Close();
                conexion.Close();
                devolver = true;
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);
            }

            return devolver;
        }

        public bool updateUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("UPDATE [dbo].[Usuarios] SET nombre= '" + en._nombre + "' ,edad=" + en._edad + "WHERE nif = '" + en._nif + "'", conexion);
                com.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);
            }

            return devolver;
        }

        public bool deleteUsuario(ENUsuario en)
        {
            bool devolver = true;
            try
            {
                SqlConnection conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand com = new SqlCommand("DELETE FROM [dbo].[Usuarios] WHERE nif = '" + en._nif + "'", conexion);
                com.ExecuteNonQuery();
                conexion.Close();
                devolver = true;
            }
            catch (SqlException ex)
            {
                devolver = false;
                Console.WriteLine("User operation has failed.Error: { 0}", ex.Message);
            }

            return devolver;
        }
    }
}
