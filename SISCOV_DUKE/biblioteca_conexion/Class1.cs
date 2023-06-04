using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_conexion
{
    public class Class1
    {

        KS_MYSQL datos = new KS_MYSQL();
        //public DataTable mostrar()
        //{
        //    return datos.CargarDatos("SELECT v.placa as placa_vehiculo,s.foto,s.tp,s.Soat,v.tipo,v.marca,v.modelo,v.carroceria,v.categoria,v.año_fabrica,v.ubicacion,s.f_vencimiento,c.nombre,c.licencia,c.fecha_vencimiento_lic  from vehiculo v INNER JOIN conductor c ON v.id_conductor = c.id_conductor INNER JOIN soat s ON s.id_soat = v.id_soat; ");
        //}

        public DataTable cargarGrid()
        {
            return datos.CargarDatos("SELECT * FROM `vehiculo_vista`;");
        }
        public DataTable filtrar(string placa)
        {
            return datos.CargarDatos("SELECT * FROM `vehiculo_vista` WHERE `placa` like '%" + placa + "%';");
        }
        public double validarplaca(string placa)
        {
            double existe = 0;
            datos.DevolverDouble("SELECT * FROM `vehiculo` WHERE `placa`='" + placa + "'; ");
            return existe;
        }
        public double registrarVehiculo(string placa, string tipo, string marca, string modelo, string carroceria, string categoria, DateTime año_fabrica, string ubicacion, string foto, string TP)
        {
            //INSERT INTO `vehiculo` (`placa`, `tipo`, `marca`, `modelo`, `carroceria`, `categoria`, `anio_fabrica`, `ubicacion`, `nombre_imagen`, `tarjeta_imagen`) VALUES ('yyy', 'ttt', 'tt', 'ttt', 'tt', 't', '2022-05-20', 'ttt', 'a', 'a')
            //INSERT INTO `vehiculo` (`placa`, `tipo`, `marca`, `modelo`, `carroceria`, `categoria`, `año_fabrica`, `ubicacion`, `nombre_imagen`, `tarjeta_imagen`, `id_soat`) VALUES ('ap78', 'tat', 'ata', 'ata', 'ata', 'ata', '2023-03-12', 'adad', 'ada', 'ada', '2')
            return datos.UltimoRegistro("INSERT INTO `vehiculo` (`placa`, `tipo`, `marca`, `modelo`, `carroceria`, `categoria`, `anio_fabrica`, `ubicacion`, `nombre_imagen`, `tarjeta_imagen`) VALUES ('" + placa + "', '" + tipo + "', '" + marca + "', '" + modelo + "', '" + carroceria + "', '" + categoria + "', '" + año_fabrica.ToString("yyyy-MM-dd") + "', '" + ubicacion + "', '" + foto + "','" + TP + "')");
            
        }
        public DataTable buscarvehiculo(string placa)
        {
            //return datos.CargarDatos("SELECT * FROM `devolvervehiculo` WHERE placa ='" + placa + "';");
            return datos.CargarDatos("SELECT * FROM `vehiculo` WHERE placa ='" + placa + "';");
        }
        public DataTable cargarConductor()
        {
            return datos.CargarDatos("SELECT * FROM `conductor`");
        }
        /// <summary>
        /// SOAT
        /// </summary>
        /// <returns></returns>
        public DataTable cargarSOAT()
        {
            return datos.CargarDatos("SELECT * FROM soat");
        }
        public DataTable cargarimgFoto(string placa)
        {
            return datos.CargarDatos("SELECT * FROM `cargarSoat` WHERE `placa`='" + placa + "'");
        }
        public void guardarSOAT(string certi, DateTime fInicio, DateTime fFinal,string seguro, int idVehiculo )
        {
            //INSERT INTO `soat` (`id_soat`, `certificado`, `f_inicio`, `f_vencimiento`, `aseguradora`, `id_vehiculo`) VALUES ('11', '00012', '2023-03-14', '2023-03-14', 'RIMAC', '1')
            datos.Consulta("INSERT INTO `soat` (`certificado`, `f_inicio`, `f_vencimiento`, `aseguradora`, `id_vehiculo`)" +
                " VALUES ('"+certi+"', '"+fInicio.ToString("yyyy-MM-dd")+"', '"+ fFinal.ToString("yyyy-MM-dd") + "', '"+seguro+"', '"+idVehiculo+"')");
        }
        public DataTable cargarVehiculo()
        {
            return datos.CargarDatos("SELECT * FROM vehiculo");
        }

        public DataTable filtrarSOAT(string certi)
        {
            return datos.CargarDatos("SELECT * FROM soat WHERE certificado ='"+certi+"'");
        }

        public string detalleConfigurable(string descripcion)
        {
            return datos.DevolverTexto("SELECT conf_detalle FROM configurable WHERE conf_descripcion = '"+ descripcion +"'");
        }


    }
}
