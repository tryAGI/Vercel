
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason
    {
        /// <summary>
        /// 
        /// </summary>
        EnospcFailure,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseFloor,
        /// <summary>
        /// 
        /// </summary>
        HighPeakDisk,
        /// <summary>
        /// 
        /// </summary>
        HighPeakMemory,
        /// <summary>
        /// 
        /// </summary>
        LongBuildDuration,
        /// <summary>
        /// 
        /// </summary>
        OomFailure,
        /// <summary>
        /// 
        /// </summary>
        ShortBuildDuration,
        /// <summary>
        /// 
        /// </summary>
        SustainedHighCpu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "enospc-failure" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}