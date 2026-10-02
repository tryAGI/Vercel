
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamDeploymentStorageRolloutCohort
    {
        /// <summary>
        ///
        /// </summary>
        AlreadyMetered,
        /// <summary>
        ///
        /// </summary>
        Extreme,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        MediumPlus,
        /// <summary>
        ///
        /// </summary>
        MeteredOptIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentStorageRolloutCohortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentStorageRolloutCohort value)
        {
            return value switch
            {
                TeamDeploymentStorageRolloutCohort.AlreadyMetered => "already_metered",
                TeamDeploymentStorageRolloutCohort.Extreme => "extreme",
                TeamDeploymentStorageRolloutCohort.High => "high",
                TeamDeploymentStorageRolloutCohort.Low => "low",
                TeamDeploymentStorageRolloutCohort.Medium => "medium",
                TeamDeploymentStorageRolloutCohort.MediumPlus => "medium_plus",
                TeamDeploymentStorageRolloutCohort.MeteredOptIn => "metered_opt_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentStorageRolloutCohort? ToEnum(string value)
        {
            return value switch
            {
                "already_metered" => TeamDeploymentStorageRolloutCohort.AlreadyMetered,
                "extreme" => TeamDeploymentStorageRolloutCohort.Extreme,
                "high" => TeamDeploymentStorageRolloutCohort.High,
                "low" => TeamDeploymentStorageRolloutCohort.Low,
                "medium" => TeamDeploymentStorageRolloutCohort.Medium,
                "medium_plus" => TeamDeploymentStorageRolloutCohort.MediumPlus,
                "metered_opt_in" => TeamDeploymentStorageRolloutCohort.MeteredOptIn,
                _ => null,
            };
        }
    }
}