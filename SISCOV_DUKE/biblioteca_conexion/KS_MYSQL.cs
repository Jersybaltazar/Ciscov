using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace biblioteca_conexion
{

    public class KS_MYSQL
    {

    
    
        private string CrearCadena()
        {
            // *** 20.-ERA DEL WEBCONFIG

            //  string server = ConfigurationManager.AppSettings.Get("server");
            //  string basedatos = ConfigurationManager.AppSettings.Get("base");
            //  string usuario = ConfigurationManager.AppSettings.Get("usuario");
            //  string clave = ConfigurationManager.AppSettings.Get("clave");

              string server = "localhost";
              string basedatos = "db_siscov_duke2";
              string usuario = "root";
              string clave = "rootleon";


                string cadena = "Server="+
                server
                +";Port=3306;Database=" +
                basedatos 
                +";Uid=" +
                usuario 
                + ";Pwd=" +
                clave
                +";protocol=socket";

         return cadena;

        }

        private static string error ="";

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        // para llenar datagrid




        public DataTable CargarDatos(string sql)
        {     
            
            MySqlConnection cn = new MySqlConnection(CrearCadena());

            try
            {
                cn.Close();
                cn.Open();


                using (MySqlDataAdapter Da = new MySqlDataAdapter(sql, cn))
                {

                DataTable Ds = new DataTable();
                Da.Fill(Ds);
                cn.Close();
                cn.Dispose();
          
                error = "";
                return Ds;

                }
                
                       
            }
            catch (Exception ex)
            {
                //MENSAJE DE ERROR
                error = ex.Message;
                cn.Close();
                cn.Dispose();
                return null;
            }

            

        }

        //para sentencias sql insert,update,delete
        public void  Consulta(string sql)
        {
            error = "";
            try
            {

                using (MySqlConnection cn2 = new MySqlConnection(CrearCadena()))
                { 
                cn2.Close();
                cn2.Open();
                MySqlCommand Cmd = new MySqlCommand(sql, cn2);
                Cmd.ExecuteNonQuery();
                cn2.Close();
                cn2.Dispose();
                error = "";
                }
           
            }

            catch (Exception ex)
         
            {
                error = ex.Message;
                //MENSAJE DE ERROR
            }

        }



        //para devolver el ultimo valor insertado en una tabla autoincrementable
      
        public long UltimoRegistro(string sql)
        {
            try
            {
                using (MySqlConnection cn2 = new MySqlConnection(CrearCadena()))
                {
                    long idtabla;
                    cn2.Close();
                    cn2.Open();
                    MySqlCommand Cmd = new MySqlCommand(sql, cn2);
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    idtabla = Convert.ToInt64(Cmd.ExecuteScalar());
                    cn2.Close();
                    cn2.Dispose();
                    error = "";
                    return idtabla;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
             
                return 0;
            }
        }
        
        //para devolver valor texto

        public string DevolverTexto(string sql)
        {
            try
            {
                using (MySqlConnection cn2 = new MySqlConnection(CrearCadena()))
                {
                    string valtabla;
                    cn2.Close();
                    cn2.Open();
                    MySqlCommand Cmd = new MySqlCommand(sql, cn2);
                    valtabla = Convert.ToString(Cmd.ExecuteScalar());
                    cn2.Close();
                    cn2.Dispose();
                    error = "";
                    return valtabla;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return "";
            }
             

        }


        //para devolver valor numerico
        public double DevolverDouble(string sql)
        {
            try
            {
                using (MySqlConnection cn2 = new MySqlConnection(CrearCadena()))
                {
                    double valtabla;
                    cn2.Close();
                    cn2.Open();
                    MySqlCommand Cmd = new MySqlCommand(sql, cn2);
                    valtabla = Convert.ToDouble(Cmd.ExecuteScalar());
                    cn2.Close();
                    cn2.Dispose();
                    error = "";
                    return valtabla;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return 0;
            }


        }


    }
}