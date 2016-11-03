using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VehicleServiceReport.DataSource;

namespace VehicleServiceReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 100;
            List<TimeSpan> viewTimes = new List<TimeSpan>();
            List<TimeSpan> storedProcedureTimes = new List<TimeSpan>();
            double averageTimeForViews;
            double averageTimeForStoredProcedures;
            for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
            {
                Console.WriteLine("Current Iteration: {0} of {1} Iterations.", currentIteration, iterations);                
                storedProcedureTimes.Add(InvokeStoredProcedure());
                viewTimes.Add(InvokeView());
                Console.Clear();
            }
            averageTimeForViews = viewTimes.Average(time => time.TotalMilliseconds);
            averageTimeForStoredProcedures = storedProcedureTimes.Average(time => time.TotalMilliseconds);
            Console.WriteLine("Time elapsed with the view: {0} Milliseconds.", averageTimeForViews);
            Console.WriteLine("Time elapsed with the stored procedure: {0} Milliseconds.", averageTimeForStoredProcedures);
            Console.ReadKey();
        }

        static TimeSpan InvokeView()
        {
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timeUsedToGetFromView;
            VehicleServiceDataAccess vehicleData = new VehicleServiceDataAccess();
            List<VehicleServiceComplete> resultFromView;

            ///Measure time used to get data from the View
            stopwatch.Start();
            resultFromView = vehicleData.GetDataFromView();
            stopwatch.Stop();
            timeUsedToGetFromView = stopwatch.Elapsed;
            stopwatch.Reset();
            return timeUsedToGetFromView;
        }

        static TimeSpan InvokeStoredProcedure()
        {
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timeUsedToGetFromStoredProcedure;
            VehicleServiceDataAccess vehicleData = new VehicleServiceDataAccess();
            List<uspVehicleServiceComplete> resultFromStoredProcedure;

            ///Measure time used to get data from the Stored Procedure            
            stopwatch.Start();
            resultFromStoredProcedure = vehicleData.GetDataFromStoredProcedure();
            stopwatch.Stop();
            timeUsedToGetFromStoredProcedure = stopwatch.Elapsed;
            stopwatch.Reset();
            return timeUsedToGetFromStoredProcedure;
        }
    }
}
