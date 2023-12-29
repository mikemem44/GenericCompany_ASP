using EL;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_tableClient
    {
        public static tableClient insert(tableClient Entidad)
        {
            using (BDContexto bd = new BDContexto())
            {
                Entidad.Activo = true;
                bd.TableClient.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static bool UpdateClient(tableClient Entidad)
        {
            using (BDContexto bd = new BDContexto())
            {
                var RegistroBD = bd.TableClient.Find(Entidad.IdCliente);
                RegistroBD.NombreCliente = Entidad.NombreCliente;
                RegistroBD.ApellidoCliente = Entidad.ApellidoCliente;
                RegistroBD.Celular = Entidad.Celular;
                RegistroBD.Direccion = Entidad.Direccion;
                return bd.SaveChanges() > 0;
            }

        }

        public static bool DeleteClient(tableClient Entidad) 
        {
            using (BDContexto bd = new BDContexto())
            {
                var RegistroBD = bd.TableClient.Find(Entidad.IdCliente);
                RegistroBD.Activo = false; 
                return bd.SaveChanges() > 0;
            }
        }

        public static List<tableClient> GetClients(bool Activo = true) 
        {
            using (BDContexto bd = new BDContexto())
            {
                return bd.TableClient.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
