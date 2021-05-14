using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryDemo.Entities
{
    //// 导航控制器配置
    [Obsolete("Please use the entities defined in ModelEntities")]
    public enum GuidanceConfig
    {
        Backstepping = 1, // 1 制导律使用backstepping control
        BacksteppingPPC = 2, //  1 使用基于预设性能，无向量场的反步法制导律
        PPCVectorTimevarying = 3, //  1 制导律使用基于预设性能的时变向量场
        NoPPCVectorNoVarying = 4, //  1 制导律使用无预设性能的固定向量场
        NoPPCVectorTimeVarying = 5, //  1 制导律使用无预设性能的时变向量场
        G3dMPF = 6 //  1 制导律使用3D移动路径跟踪方法
    }

    [Obsolete("Please use the entities defined in ModelEntities")]
    public record Configuration
    {
        public int Id { get; set; }
        public GuidanceConfig GuidanceConfig { get; set; }

        public static bool IsSame(Configuration a, Configuration b)
        {
            return a.GuidanceConfig == b.GuidanceConfig;
        }
    }
}
