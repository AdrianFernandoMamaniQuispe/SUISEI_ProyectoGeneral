using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUISEI.MODELO;


namespace SUISEI.CONTROLADOR
{
    public class clsCliente
    {
        public List<OBTENER_CLIENTES_2_Result> obtenerClientes(string n)
        {
            try
            {
                using (SUISEIEntities bd = new SUISEIEntities())
                {
                    var consulta = bd.OBTENER_CLIENTES_2(null, n).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarCliente(string nombres, string apellidoPaterno, string apellidoMaterno, int edad,
            string sexo, string direccion, string telefono, string dni)
        {

            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter idCliente = new System.Data.Entity.Core.Objects.ObjectParameter("idCliente", typeof(int));

                using (SUISEIEntities bd = new SUISEIEntities())
                {
                    bd.INSERTAR_CLIENTE(nombres, apellidoPaterno, apellidoMaterno, edad, sexo, direccion, telefono, dni, idCliente);
                    bd.SaveChanges();
                }

                return Convert.ToInt32(idCliente.Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void EliminarCliente(int pIdCliente)
        {
            try
            {
                using (SUISEIEntities bd = new SUISEIEntities())
                {
                    bd.ELIMINAR_CLIENTE(pIdCliente);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificarCliente(int pIdCliente, string nombres, string apellidoPaterno, string apellidoMaterno, int edad,
            string sexo, string direccion, string telefono, string dni)
        {
            try

            {
                using (SUISEIEntities bd = new SUISEIEntities())
                {
                    bd.MODIFICAR_CLIENTE(pIdCliente, nombres, apellidoPaterno, apellidoMaterno, edad, sexo, direccion, telefono, dni);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }

}

