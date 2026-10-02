
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamDeploymentStorageRolloutMeterReason
    {
        /// <summary>
        ///
        /// </summary>
        LowScheduled,
        /// <summary>
        ///
        /// </summary>
        MediumScheduled,
        /// <summary>
        ///
        /// </summary>
        RetentionOptOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentStorageRolloutMeterReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentStorageRolloutMeterReason value)
        {
            return value switch
            {
                TeamDeploymentStorageRolloutMeterReason.LowScheduled => "low_scheduled",
                TeamDeploymentStorageRolloutMeterReason.MediumScheduled => "medium_scheduled",
                TeamDeploymentStorageRolloutMeterReason.RetentionOptOut => "retention_opt_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentStorageRolloutMeterReason? ToEnum(string value)
        {
            return value switch
            {
                "low_scheduled" => TeamDeploymentStorageRolloutMeterReason.LowScheduled,
                "medium_scheduled" => TeamDeploymentStorageRolloutMeterReason.MediumScheduled,
                "retention_opt_out" => TeamDeploymentStorageRolloutMeterReason.RetentionOptOut,
                _ => null,
            };
        }
    }
}