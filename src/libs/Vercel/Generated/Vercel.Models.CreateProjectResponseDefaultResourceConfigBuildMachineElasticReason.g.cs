
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason
    {
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
    public static class CreateProjectResponseDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "build-timeout-failure" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => CreateProjectResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}