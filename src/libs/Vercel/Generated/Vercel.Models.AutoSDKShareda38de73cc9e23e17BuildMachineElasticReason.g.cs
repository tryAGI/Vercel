
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason
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
    public static class AutoSDKShareda38de73cc9e23e17BuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}