
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestResourceConfigBuildMachineElasticReason
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
    public static class UpdateProjectRequestResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UpdateProjectRequestResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UpdateProjectRequestResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}