
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseResourceConfigBuildMachineElasticReason
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
    public static class UpdateProjectResponseResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UpdateProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UpdateProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}