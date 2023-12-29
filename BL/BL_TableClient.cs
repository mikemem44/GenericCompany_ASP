using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_TableClient
    {
        public static tableClient insert(tableClient Entidad)
        {
            return DAL_tableClient.insert(Entidad);
        }

        public static bool UpdateClient(tableClient Entidad)
        {
            return DAL_tableClient.UpdateClient(Entidad);
        }
        public static bool DeleteClient(tableClient Entidad)
        {
            return DAL_tableClient.DeleteClient(Entidad);
        }
        public static List<tableClient> GetClients(bool Activo = true)
        {
            return DAL_tableClient.GetClients(Activo);
        }
    }
}
