using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities
{
    public class BasicInformation
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Configuration SimConfiguration { get; set; }
        public Initialization SimInitialization { get; set; }
        public string PathToData { get; set; }
    }
}
