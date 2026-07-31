
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason
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
    public static class UploadProjectAvatarResponseResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UploadProjectAvatarResponseResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}