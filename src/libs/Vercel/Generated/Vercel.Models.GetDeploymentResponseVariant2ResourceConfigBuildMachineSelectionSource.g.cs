
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource
    {
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
        TeamSetting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ElasticAlgorithm => "elastic-algorithm",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.PlanDefault => "plan-default",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ProjectSetting => "project-setting",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "elastic-algorithm" => GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ElasticAlgorithm,
                "plan-default" => GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.PlanDefault,
                "project-setting" => GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ProjectSetting,
                "team-setting" => GetDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}