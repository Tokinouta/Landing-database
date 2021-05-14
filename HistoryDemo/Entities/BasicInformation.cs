using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryDemo.Entities
{
    [Obsolete("Please use the entities defined in ModelEntities")]
    public record BasicInformation
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Configuration SimConfiguration { get; set; }
        public Initialization SimInitialization { get; set; }
        public string PathToData { get; set; }
    }
}
