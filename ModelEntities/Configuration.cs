using ModelEntities.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities
{
    public class Configuration
    {
        public int Id { get; set; }
        public GuidanceConfig GuidanceController { get; set; }
        public AttitudeConfig AttitudeController { get; set; }
        public AngularRateConfig AngularRateController { get; set; }
        public DisturbanceObserverConfig DisturbanceObserver { get; set; }

        // 导数滤波器配置参数
        public GuidanceFilters GuidanceFilter { get; set; }
        public AttitudeFilters AttitudeFilter { get; set; }
        // 1 使用tracking_differentiator计算导数
        public bool UseAttitudeTrackingDifferentiator { get; set; }

        // 轨迹配置
        public TrajactoryType TrajactoryConfig { get; set; }

        // 扰动类型配置
        public bool UseDisturbanceTypeI { get; set; } // 1 典型舰尾流扰动

        // 是否使能风场扰动 0:不使能 1:使能
        public bool IsWindEnabled { get; set; }
        // 是否使能甲板运动补偿 0:不使能 1:使能
        public bool IsDeckCompensationEnabled { get; set; }

        public bool UseL1Adaptive { get; set; }
    }
}
