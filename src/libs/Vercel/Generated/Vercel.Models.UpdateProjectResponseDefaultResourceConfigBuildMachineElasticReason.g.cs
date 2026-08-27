
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason
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
    public static class UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UpdateProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}