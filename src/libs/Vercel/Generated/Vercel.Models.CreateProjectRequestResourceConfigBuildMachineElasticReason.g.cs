
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectRequestResourceConfigBuildMachineElasticReason
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
    public static class CreateProjectRequestResourceConfigBuildMachineElasticReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestResourceConfigBuildMachineElasticReason value)
        {
            return value switch
            {
                CreateProjectRequestResourceConfigBuildMachineElasticReason.BasicFloor => "basic-floor",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.BuildTimeoutFailure => "build-timeout-failure",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.EnospcFailure => "enospc-failure",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.EnterpriseFloor => "enterprise-floor",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakDisk => "high-peak-disk",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakMemory => "high-peak-memory",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.LongBuildDuration => "long-build-duration",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.OomFailure => "oom-failure",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.ShortBuildDuration => "short-build-duration",
                CreateProjectRequestResourceConfigBuildMachineElasticReason.SustainedHighCpu => "sustained-high-cpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestResourceConfigBuildMachineElasticReason? ToEnum(string value)
        {
            return value switch
            {
                "basic-floor" => CreateProjectRequestResourceConfigBuildMachineElasticReason.BasicFloor,
                "build-timeout-failure" => CreateProjectRequestResourceConfigBuildMachineElasticReason.BuildTimeoutFailure,
                "enospc-failure" => CreateProjectRequestResourceConfigBuildMachineElasticReason.EnospcFailure,
                "enterprise-floor" => CreateProjectRequestResourceConfigBuildMachineElasticReason.EnterpriseFloor,
                "high-peak-disk" => CreateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakDisk,
                "high-peak-memory" => CreateProjectRequestResourceConfigBuildMachineElasticReason.HighPeakMemory,
                "long-build-duration" => CreateProjectRequestResourceConfigBuildMachineElasticReason.LongBuildDuration,
                "oom-failure" => CreateProjectRequestResourceConfigBuildMachineElasticReason.OomFailure,
                "short-build-duration" => CreateProjectRequestResourceConfigBuildMachineElasticReason.ShortBuildDuration,
                "sustained-high-cpu" => CreateProjectRequestResourceConfigBuildMachineElasticReason.SustainedHighCpu,
                _ => null,
            };
        }
    }
}