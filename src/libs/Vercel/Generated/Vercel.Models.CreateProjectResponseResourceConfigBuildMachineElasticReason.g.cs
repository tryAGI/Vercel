
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseResourceConfigBuildMachineElasticReason
    {
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
    public static class CreateProjectResponseResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                CreateProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                CreateProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "enospc-failure" => CreateProjectResponseResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => CreateProjectResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => CreateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => CreateProjectResponseResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => CreateProjectResponseResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => CreateProjectResponseResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => CreateProjectResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => CreateProjectResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}