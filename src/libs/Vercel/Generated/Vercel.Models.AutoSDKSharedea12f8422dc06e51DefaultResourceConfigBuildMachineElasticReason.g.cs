
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}