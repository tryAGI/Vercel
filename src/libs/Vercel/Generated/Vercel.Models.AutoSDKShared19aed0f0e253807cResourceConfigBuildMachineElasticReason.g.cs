
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShared19aed0f0e253807cResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}