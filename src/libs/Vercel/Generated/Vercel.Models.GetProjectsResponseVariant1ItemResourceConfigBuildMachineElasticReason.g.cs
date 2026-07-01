
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason
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
    public static class GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "build-timeout-failure" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}