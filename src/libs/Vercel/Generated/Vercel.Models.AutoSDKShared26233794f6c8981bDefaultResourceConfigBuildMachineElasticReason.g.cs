
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKShared26233794f6c8981bDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}