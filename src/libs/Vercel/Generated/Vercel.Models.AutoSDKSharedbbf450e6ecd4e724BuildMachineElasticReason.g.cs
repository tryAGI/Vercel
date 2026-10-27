
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason
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
    public static class AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}