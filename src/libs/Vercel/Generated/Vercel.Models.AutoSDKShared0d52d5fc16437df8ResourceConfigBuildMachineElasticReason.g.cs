
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShared0d52d5fc16437df8ResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}