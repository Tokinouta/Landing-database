using HistoryDemo.Entities;
using System;

namespace HistoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var array = new int[] { 1, 2, 3, 4, 5 };
            var slice1 = array[2..^3];    // array[new Range(2, new Index(3, fromEnd: true))]
            var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
            var slice3 = array[2..^1];      // array[Range.StartAt(2)]
            var slice4 = array[..];       // array[Range.All]
            using (var db = new AppDbContext())
            {
                var ini = new Initialization()
                {
                    InitialPositionX = 1,
                    InitialPositionY = 2,
                    InitialPositionZ = 3,
                    InitialAttitudePhi = 4,
                    InitialAttitudePsi = 5,
                    InitialAttitudeTheta = 6
                };
                var conf = new Configuration()
                {
                    GuidanceConfig = GuidanceConfig.G3dMPF
                };
                var bi = new BasicInformation()
                {
                    //Id = 1, 
                    DateTime = DateTime.Now,
                    SimConfiguration = conf,
                    SimInitialization = ini,
                    PathToData = "rarara"
                };
                db.Add(bi);
                db.Add(ini);
                db.Add(conf);
                db.SaveChanges();
            }
        }
    }
}
