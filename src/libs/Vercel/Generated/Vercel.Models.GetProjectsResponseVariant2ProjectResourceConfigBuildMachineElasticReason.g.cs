
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason
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
    public static class GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}