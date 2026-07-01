
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseResourceConfigBuildMachineElasticReason
    {
        /// <summary>
        /// 
        /// </summary>
        BuildTimeoutFailure,
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
    public static class GetProjectResponseResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                GetProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectResponseResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "build-timeout-failure" => GetProjectResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => GetProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectResponseResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}