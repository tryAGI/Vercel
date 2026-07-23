
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
    /// </summary>
    public enum CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency
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
    public static class CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.ProjectSetting => "PROJECT_SETTING",
                CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.SkipQueue => "SKIP_QUEUE",
                CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.TeamSetting => "TEAM_SETTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency? ToEnum(string value)
        {
            return value switch
            {
                "PROJECT_SETTING" => CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.ProjectSetting,
                "SKIP_QUEUE" => CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.SkipQueue,
                "TEAM_SETTING" => CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency.TeamSetting,
                _ => null,
            };
        }
    }
}