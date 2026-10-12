
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}