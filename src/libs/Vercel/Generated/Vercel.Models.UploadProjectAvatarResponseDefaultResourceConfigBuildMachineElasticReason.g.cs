
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason
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
    public static class UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "build-timeout-failure" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}