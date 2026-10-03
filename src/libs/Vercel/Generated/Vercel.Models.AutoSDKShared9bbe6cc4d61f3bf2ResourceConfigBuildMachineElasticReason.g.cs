
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}