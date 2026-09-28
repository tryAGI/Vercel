
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShared39d2a20705988a8dResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}