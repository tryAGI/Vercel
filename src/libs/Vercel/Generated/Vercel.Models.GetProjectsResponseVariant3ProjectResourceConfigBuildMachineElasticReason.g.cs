
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason
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
    public static class GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "enospc-failure" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}