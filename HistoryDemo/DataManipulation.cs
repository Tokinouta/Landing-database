using ModelEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HistoryDemo
{
    public class DataManipulation
    {
        async public static void Create(Initialization ini, Configuration conf, string fileName)
        {
            Console.WriteLine("rarar");
            await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                Console.WriteLine("rarar");
                using var db = new AppDbContext();
                // https://stackoverflow.com/questions/1324199/sequence-contains-no-elements
                // use FirstOrDefault instead of First
                Configuration sameConfig = db.Configurations.FirstOrDefault(s =>
                    s.GuidanceController == conf.GuidanceController
                    && s.AttitudeController == conf.AttitudeController
                    && s.AngularRateController == conf.AngularRateController
                    && s.DisturbanceObserver == conf.DisturbanceObserver
                    && s.GuidanceFilter == conf.GuidanceFilter
                    && s.AttitudeFilter == conf.AttitudeFilter
                    && s.UseAttitudeTrackingDifferentiator == conf.UseAttitudeTrackingDifferentiator
                    && s.TrajactoryConfig == conf.TrajactoryConfig
                    && s.UseDisturbanceTypeI == conf.UseDisturbanceTypeI
                    && s.IsDeckCompensationEnabled == conf.IsDeckCompensationEnabled
                    && s.IsWindEnabled == conf.IsWindEnabled
                    && s.UseL1Adaptive == conf.UseL1Adaptive
                );

                Initialization sameInit = db.Initializations.FirstOrDefault(s =>
                    s.X == ini.X
                    && s.Y == ini.Y
                    && s.Z == ini.Z
                    && s.Phi == ini.Phi
                    && s.Psi == ini.Psi
                    && s.Theta == ini.Theta
                    && s.P == ini.P
                    && s.Q == ini.Q
                    && s.R == ini.R
                    && s.Alpha == ini.Alpha
                );

                //foreach (var item in s.GetType().GetProperties())
                //{
                //    if (item.Name != nameof(s.Id)
                //    && (GuidanceConfig)item.GetValue(s) != (GuidanceConfig)item.GetValue(conf))
                //    {
                //        return false;
                //    }
                //}
                //return true;

                // });
                var b = sameConfig == conf;
                var bi = new BasicInformation()
                {
                    //Id = 1, 
                    DateTime = DateTime.Now,
                    SimConfiguration = sameConfig ?? conf,
                    SimInitialization = sameInit ?? ini,
                    PathToData = fileName
                };
                //var t = db.Configurations.Find(new HistoryDemo.Entities.Configuration(){
                //    GuidanceConfig = (HistoryDemo.Entities.GuidanceConfig)Configuration.GuidanceController
                //});
                db.Add(bi);
                if (sameInit is null)
                {
                    db.Add(ini);
                }
                if (sameConfig is null)
                {
                    db.Add(conf);
                }
                db.SaveChanges();
                Console.WriteLine("Saved");
            });
        }

        async public static void Delete()
        {
            await Task.Run(() => { });
        }

        async public static void Update()
        {
            await Task.Run(() => { });
        }

        async public static void Read()
        {
            await Task.Run(() =>
            {
                using var db = new AppDbContext();
                var t = db.BasicInformations.First();
                if (!File.Exists(t.PathToData))
                {
                    // Create a file to write to.
                    using StreamWriter sw = File.CreateText(t.PathToData);
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            });
        }
    }
}
