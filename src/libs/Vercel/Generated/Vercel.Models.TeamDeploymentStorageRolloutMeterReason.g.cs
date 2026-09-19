
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
        HighRetentionOptIn,
        /// <summary>
        ///
        /// </summary>
        LowScheduled,
        /// <summary>
        ///
        /// </summary>
        MediumScheduled,
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
                TeamDeploymentStorageRolloutMeterReason.HighRetentionOptIn => "high_retention_opt_in",
                TeamDeploymentStorageRolloutMeterReason.LowScheduled => "low_scheduled",
                TeamDeploymentStorageRolloutMeterReason.MediumScheduled => "medium_scheduled",
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
                "high_retention_opt_in" => TeamDeploymentStorageRolloutMeterReason.HighRetentionOptIn,
                "low_scheduled" => TeamDeploymentStorageRolloutMeterReason.LowScheduled,
                "medium_scheduled" => TeamDeploymentStorageRolloutMeterReason.MediumScheduled,
                _ => null,
            };
        }
    }
}