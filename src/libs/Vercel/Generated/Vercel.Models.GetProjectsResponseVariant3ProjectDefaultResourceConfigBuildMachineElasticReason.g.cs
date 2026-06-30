
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason
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
    public static class GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "enospc-failure" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}