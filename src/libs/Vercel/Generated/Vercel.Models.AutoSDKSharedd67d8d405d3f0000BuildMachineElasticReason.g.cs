
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason
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
    public static class AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.BasicFloor => "basic-floor",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.EnospcFailure => "enospc-failure",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.OomFailure => "oom-failure",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.OomFailure,
                "short-build-duration" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}