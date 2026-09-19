
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
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
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
                TeamDeploymentStorageRolloutCohort.High => "high",
                TeamDeploymentStorageRolloutCohort.Low => "low",
                TeamDeploymentStorageRolloutCohort.Medium => "medium",
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
                "high" => TeamDeploymentStorageRolloutCohort.High,
                "low" => TeamDeploymentStorageRolloutCohort.Low,
                "medium" => TeamDeploymentStorageRolloutCohort.Medium,
                _ => null,
            };
        }
    }
}