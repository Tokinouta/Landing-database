using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryDemo.Entities
{
    [Obsolete("Please use the entities defined in ModelEntities")]
    public record Initialization
    {
        public int Id { get; set; }
        public double InitialPositionX { get; set; }
        public double InitialPositionY { get; set; }
        public double InitialPositionZ { get; set; }
        public double InitialAttitudePhi { get; set; }
        public double InitialAttitudePsi { get; set; }
        public double InitialAttitudeTheta { get; set; }
    }
}
