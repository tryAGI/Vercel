
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDefaultResourceConfigBuildMachineElasticReason
    {
        /// <summary>
        /// 
        /// </summary>
        BasicFloor,
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
    public static class GetProjectResponseDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}