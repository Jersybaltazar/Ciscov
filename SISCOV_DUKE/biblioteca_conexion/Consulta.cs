using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace biblioteca_conexion
{
     public class Consulta
    {
        KS_MYSQL datos = new KS_MYSQL();

        public string Registrarproducto(string descripcion, string stock, string cod_producto)
        {
            datos.Consulta("call registro_producto ('" + descripcion + "', '" + stock + "', '" + cod_producto + "')");

            string resultado = "";
            if (datos.Error != "")
            {
                resultado = datos.Error;
            }
            else
            {
                resultado = "ok";
            }
            return resultado;
        }

        public void Registrarconductro(string nombre, string licencia, string cod_conductor, DateTime fvenci)
        {
            datos.Consulta("call registro_conductor('" + nombre + "', '" + licencia+ "', '"+ cod_conductor+"','"+fvenci.ToString("yyyy-MM-dd")+"')");
        }

        public double Registrarfactura(string num_factura, string fecha_emision, double importe_total, string ruc, string proveedor)
        {
            return datos.UltimoRegistro("INSERT INTO `facturas` (`numFactura`, `fechaEmision`, `importe_total`, `ruc`, `proveedor`) VALUES ('" + num_factura+"', '"+fecha_emision+"', '"+importe_total+"', '"+ruc+"', '"+ proveedor + "')");
        }


        public void RegistrarOrden(int id_factura, string oreden_credito, int id_vehiculo, int id_producto, string kilometraje, int id_conductor, string fecha_orden, double galon, double precio_galon, double importe, string unidad_lugar)
        {
            var recorrido = devolverUltimoRecorrido(id_vehiculo);
            var diferencia = double.Parse(kilometraje) - recorrido;
            datos.Consulta("INSERT INTO `ordencreditos` (`id_factura`, `ordenCredito`, `id_vehiculo`, `id_producto`, `kilometraje`, `id_conductor`, `fechaOrden`, `galon`, `precioGalon`, `importe`,`unidad_lugar`,`recorrido`) " +
                "VALUES ('" + id_factura +"', '"+oreden_credito+"', '"+id_vehiculo+"', '"+id_producto+"', '"+kilometraje+"', '"+id_conductor+"', '"+fecha_orden+"', '"+galon+"', '"+precio_galon+"', '"+importe+"','"+unidad_lugar+"','"+ diferencia +"')");
        }

        public DataTable tablaplaca()
        {
            return datos.CargarDatos("select * from vehiculo ORDER BY vehiculo.id_vehiculo DESC"); 
        }

        public DataTable tablaproducto()
        {
            return datos.CargarDatos("select * from productos");
        }

        public DataTable tablaconductor()
        {
            return datos.CargarDatos("select * from conductores");
        }

        public DataTable factura()
        {
            return datos.CargarDatos("select * from facturas;");
        }

        //REPORTES
        public DataTable reporteFactura()
        {
            return datos.CargarDatos("SELECT * FROM vista_factura");
        }

        public DataTable reporteOrdenfactura()
        {
            return datos.CargarDatos("SELECT * FROM vista_orden");
        }
        //dato de reporte
        public DataTable cristalOrdenfactura(string finicio, string ffinal)
        {
            return datos.CargarDatos("SELECT * FROM ordencreditos BETWEEN '"+finicio+"' and '"+ffinal+"' ");
        }

        public DataTable cristalFechaRecorriod(string fInicio, string ffinal)
        {
            return datos.CargarDatos("SELECT * FROM reporte_fecharecorrido WHERE fechaOrden BETWEEN '" + fInicio + "' and '"+ ffinal +"'");
        }
        public DataTable cristalFechaRecorriod()
        {
            return datos.CargarDatos("SELECT * FROM reporte_fecharecorrido ");
        }
        //dato de reporte







        public DataTable reporteOrdenfacturafecha(string fecha_incio, string fecha_final)
        {
            return datos.CargarDatos("SELECT * FROM vista_orden WHERE `Fecha Orden` BETWEEN '" + fecha_incio + "' AND '" + fecha_final + "' ");
             
        }

        public DataTable reportefacturafecha(string fecha_incio, string fecha_final)
        {
            return datos.CargarDatos("SELECT * FROM vista_factura WHERE `Fecha Emision` BETWEEN '" + fecha_incio + "' AND '" + fecha_final + "' ");

        }

        public DataTable buscarFactura(string numFactura)
        {
            return datos.CargarDatos("SELECT * FROM facturas WHERE numFactura = '"+ numFactura+ "'");
        }
        public DataTable buscarConductor(string codigo)
        {
            return datos.CargarDatos("SELECT * FROM conductores WHERE codigo = '" + codigo + "'");
        }

        public DataTable reporteVehiculoSOAT()
        {
            return datos.CargarDatos("SELECT * FROM vista_vehiculo");
        }

        public DataTable reporteVehiculoSOATF(string fecha_incio, string fecha_final)
        {
            return datos.CargarDatos("SELECT * FROM vista_vehiculo WHERE `F. VENCIMIENTO SOAT` BETWEEN '" + fecha_incio + "' AND '" + fecha_final + "' ");

        }
        public DataTable reporteORDENDATOS()
        {
            return datos.CargarDatos("SELECT * FROM vista_orden_datos");
        }


        //devolver el ultimo recorrido el id_vehiculo
        public double devolverUltimoRecorrido(int idVehiculo)
        {
            return datos.DevolverDouble("Select kilometraje from ordencreditos WHERE id_vehiculo = '" + idVehiculo+ "' order by id_ordenCredito DESC LIMIT 1");
        }


        //consultas  de emerson
        public DataTable reporteOrdenfacturaCR(string fechainicio, string fechafin)
        {
            return datos.CargarDatos("SELECT * FROM GRAFICO WHERE fechaOrden BETWEEN '" + fechainicio + "' AND '" + fechafin + "'; ");
        }
        public DataTable reporteOrdenfacturaCRy()
        {
            return datos.CargarDatos("SELECT * FROM GRAFICO");
        }

        //CONSULTA DE ANDRE
        public DataTable buscarGalonCR(string placa)
        {
            return datos.CargarDatos("SELECT * FROM vista_galon WHERE placa LIKE '%" + placa + "%';");
        }
        public DataTable reporteGalonPlacaCRy()
        {
            return datos.CargarDatos("SELECT * FROM vista_galon");
        }

        public DataTable buscarGalonFecha(string fecha_inicio1, string fecha_final1)
        {
            return datos.CargarDatos("SELECT * FROM vista_galon WHERE `fechaOrden` BETWEEN '" + fecha_inicio1 + "' AND '" + fecha_final1 + "' ");
        }

    }
}
