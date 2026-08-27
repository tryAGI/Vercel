
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason
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
    public static class GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}