using System;
using System.Collections.Generic;
using System.Diagnostics;
using VehicleServiceReport.DataSource;

namespace VehicleServiceReport
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleServiceDataAccess vehicleData = new VehicleServiceDataAccess();
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timeUsedToGetFromView;
            List<VehicleServiceComplete> resultFromView;
            TimeSpan timeUsedToGetFromStoredProcedure;
            List<uspVehicleServiceComplete> resultFromStoredProcedure;
            ///Measure time used to get data from the View
            stopwatch.Start();
            resultFromView = vehicleData.GetDataFromView();
            stopwatch.Stop();
            timeUsedToGetFromView = stopwatch.Elapsed;
            stopwatch.Reset();
            ///Measure time used to get data from the Stored Procedure
            stopwatch.Start();
            resultFromStoredProcedure = vehicleData.GetDataFromStoredProcedure();
            stopwatch.Stop();
            timeUsedToGetFromStoredProcedure = stopwatch.Elapsed;

            Console.WriteLine("Time elapsed with the view: {0} Milliseconds. Result: {1} records.", timeUsedToGetFromView.TotalMilliseconds, resultFromView.Count);
            Console.WriteLine("Time elapsed with the stored procedure: {0} Milliseconds. Result: {1} records.", timeUsedToGetFromStoredProcedure.TotalMilliseconds, resultFromStoredProcedure.Count);
            Console.ReadKey();
        }
    }
}
