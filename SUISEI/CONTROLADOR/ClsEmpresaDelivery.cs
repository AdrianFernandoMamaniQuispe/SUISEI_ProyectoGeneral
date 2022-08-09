using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISEI.CONTROLADOR
{
    internal class ClsEmpresaDelivery
    {


        //============================== FUNCIÓN LISTAR LAS EMPRESAS DE DELIVERY ================================================
        public List<Delivery> ListarEmpresasDeliveries()
        {

            using (SUISEIv3Entities bd = new SUISEIv3Entities())
            {
                return bd.Delivery.ToList();
            }


        }
        //=======================================================================================================================



        public void ingresarDatosDelivery(int idDelivery, string dRuc, string dNombre, string dTelefono, string dEmail, string dDireccion, string DHorarioAtencion)
        {


            using (SUISEIv3Entities bd = new SUISEIv3Entities())
            {
                //================================== INSTANCIAMOS datosDelivery DEL TIPO Delivery ================================
                Delivery datosDelivery = new Delivery();
                datosDelivery.id_delivey = idDelivery;
                datosDelivery.d_ruc = dRuc;
                datosDelivery.d_nombre = dNombre;
                datosDelivery.d_telefono = dTelefono;
                datosDelivery.d_email = dEmail;
                datosDelivery.d_direccion = dDireccion;
                datosDelivery.d_horario_atencion = DHorarioAtencion;
                //========================= ENVIAMOS LOS DATOS A LA BASE DE DATOS > DELIVERY, LOS DATOS GUARDADOS EN datosDelivery======
                bd.Delivery.Add(datosDelivery);
                bd.SaveChanges();



            }

        }



    }
}
