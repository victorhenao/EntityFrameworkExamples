using System.Collections.Generic;
using System.Linq;
using VehicleServiceReport.DataSource;

namespace VehicleServiceReport
{
    public class VehicleServiceDataAccess
    {
        public List<VehicleServiceComplete> GetDataFromView()
        {
            List<VehicleServiceComplete> result = new List<VehicleServiceComplete>();
            using (VehicleServiceEntities context = new VehicleServiceEntities())
            {
                result = context.VehicleServiceComplete.ToList();
            }
            return result;
        }

        public List<uspVehicleServiceComplete> GetDataFromStoredProcedure()
        {
            List<uspVehicleServiceComplete> result = new List<uspVehicleServiceComplete>();
            using (VehicleServiceEntities context = new VehicleServiceEntities())
            {
                result = context.uspVehicleServiceComplete().ToList();
            }
            return result;
        }
    }
}
