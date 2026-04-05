
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
    /// </summary>
    public enum CancelDeploymentResponseConfigResourceConfigElasticConcurrency
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
    public static class CancelDeploymentResponseConfigResourceConfigElasticConcurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseConfigResourceConfigElasticConcurrency value)
        {
            return value switch
            {
                CancelDeploymentResponseConfigResourceConfigElasticConcurrency.ProjectSetting => "PROJECT_SETTING",
                CancelDeploymentResponseConfigResourceConfigElasticConcurrency.SkipQueue => "SKIP_QUEUE",
                CancelDeploymentResponseConfigResourceConfigElasticConcurrency.TeamSetting => "TEAM_SETTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseConfigResourceConfigElasticConcurrency? ToEnum(string value)
        {
            return value switch
            {
                "PROJECT_SETTING" => CancelDeploymentResponseConfigResourceConfigElasticConcurrency.ProjectSetting,
                "SKIP_QUEUE" => CancelDeploymentResponseConfigResourceConfigElasticConcurrency.SkipQueue,
                "TEAM_SETTING" => CancelDeploymentResponseConfigResourceConfigElasticConcurrency.TeamSetting,
                _ => null,
            };
        }
    }
}