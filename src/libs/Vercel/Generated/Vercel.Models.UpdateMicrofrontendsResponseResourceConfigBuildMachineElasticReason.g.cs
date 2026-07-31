
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason
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
    public static class UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UpdateMicrofrontendsResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}