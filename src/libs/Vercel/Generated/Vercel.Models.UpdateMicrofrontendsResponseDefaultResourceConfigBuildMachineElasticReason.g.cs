
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason
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
    public static class UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "build-timeout-failure" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}