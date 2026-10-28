
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant2SelectionSource
    {
        /// <summary>
        ///
        /// </summary>
        DeploymentOverride,
        /// <summary>
        ///
        /// </summary>
        ElasticAlgorithm,
        /// <summary>
        ///
        /// </summary>
        PlanDefault,
        /// <summary>
        ///
        /// </summary>
        ProjectSetting,
        /// <summary>
        ///
        /// </summary>
        TeamEntitlement,
        /// <summary>
        ///
        /// </summary>
        TeamSetting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6120795acc1bdfb3Variant2SelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant2SelectionSource value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.DeploymentOverride => "deployment-override",
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.ElasticAlgorithm => "elastic-algorithm",
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.PlanDefault => "plan-default",
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.ProjectSetting => "project-setting",
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.TeamEntitlement => "team-entitlement",
                AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant2SelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "deployment-override" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.DeploymentOverride,
                "elastic-algorithm" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.ElasticAlgorithm,
                "plan-default" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.PlanDefault,
                "project-setting" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.ProjectSetting,
                "team-entitlement" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.TeamEntitlement,
                "team-setting" => AutoSDKShared6120795acc1bdfb3Variant2SelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}