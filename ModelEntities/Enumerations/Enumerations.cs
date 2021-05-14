using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities.Enumerations
{
    // 导航控制器配置
    public enum GuidanceConfig
    {
        Backstepping , // 1 制导律使用backstepping control
        BacksteppingPPC, //  1 使用基于预设性能，无向量场的反步法制导律
        PPCVectorTimevarying, //  1 制导律使用基于预设性能的时变向量场
        NoPPCVectorNoVarying, //  1 制导律使用无预设性能的固定向量场
        NoPPCVectorTimeVarying, //  1 制导律使用无预设性能的时变向量场
        G3dMPF //  1 制导律使用3D移动路径跟踪方法
    }

    // 姿态控制器配置
    public enum AttitudeConfig
    {
        Backstepping, //  1 姿态控制律使用Backstepping
        IDLC //  1 姿态控制律使用直接升力控制
    }

    // 干扰观测器配置
    public enum DisturbanceObserverConfig
    {
        NDO, // 1 使用 nonlinear disturbance observer filter
        FTO, // 1 使用fixed-time disturbance observer filter
        HOSMO, // 1 使用high order sliding mode observer filter
        ESO, // 1 使用ESO观测器
        NONE // 1 不使用干扰观测器
    }

    // 轨迹配置
    public enum TrajactoryType
    {
        TypeI, // 1 使用x系数为1的轨迹
        TypeII // 1 使用y，z系数为1的轨迹
    }

    public enum AngularRateConfig
    {
        BS,
        NDI
    }

    public enum GuidanceFilters
    {
        Command // 1 使用command filter计算导数
    }

    public enum AttitudeFilters
    {
        Command // 1 使用command filter计算导数
    }
}
