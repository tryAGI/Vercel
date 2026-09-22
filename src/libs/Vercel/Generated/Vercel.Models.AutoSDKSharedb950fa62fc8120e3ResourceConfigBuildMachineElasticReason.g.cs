
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}