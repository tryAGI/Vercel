
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
    /// </summary>
    public enum GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency
    {
        /// <summary>
        /// Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
        /// </summary>
        ProjectSetting,
        /// <summary>
        /// Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
        /// </summary>
        SkipQueue,
        /// <summary>
        /// Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
        /// </summary>
        TeamSetting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.ProjectSetting => "PROJECT_SETTING",
                GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.SkipQueue => "SKIP_QUEUE",
                GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.TeamSetting => "TEAM_SETTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency? ToEnum(string value)
        {
            return value switch
            {
                "PROJECT_SETTING" => GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.ProjectSetting,
                "SKIP_QUEUE" => GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.SkipQueue,
                "TEAM_SETTING" => GetDeploymentResponseVariant1ConfigResourceConfigElasticConcurrency.TeamSetting,
                _ => null,
            };
        }
    }
}