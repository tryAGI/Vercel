
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
    /// </summary>
    public enum GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency
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
    public static class GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.ProjectSetting => "PROJECT_SETTING",
                GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.SkipQueue => "SKIP_QUEUE",
                GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.TeamSetting => "TEAM_SETTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency? ToEnum(string value)
        {
            return value switch
            {
                "PROJECT_SETTING" => GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.ProjectSetting,
                "SKIP_QUEUE" => GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.SkipQueue,
                "TEAM_SETTING" => GetDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.TeamSetting,
                _ => null,
            };
        }
    }
}