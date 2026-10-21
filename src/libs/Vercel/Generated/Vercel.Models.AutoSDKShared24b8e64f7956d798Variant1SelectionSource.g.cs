
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant1SelectionSource
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
    public static class AutoSDKShared24b8e64f7956d798Variant1SelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant1SelectionSource value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.DeploymentOverride => "deployment-override",
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.ElasticAlgorithm => "elastic-algorithm",
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.PlanDefault => "plan-default",
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.ProjectSetting => "project-setting",
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.TeamEntitlement => "team-entitlement",
                AutoSDKShared24b8e64f7956d798Variant1SelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant1SelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "deployment-override" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.DeploymentOverride,
                "elastic-algorithm" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.ElasticAlgorithm,
                "plan-default" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.PlanDefault,
                "project-setting" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.ProjectSetting,
                "team-entitlement" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.TeamEntitlement,
                "team-setting" => AutoSDKShared24b8e64f7956d798Variant1SelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}