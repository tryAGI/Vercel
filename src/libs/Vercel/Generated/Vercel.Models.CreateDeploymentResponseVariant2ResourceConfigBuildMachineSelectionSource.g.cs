
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource
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
    public static class CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ElasticAlgorithm => "elastic-algorithm",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.PlanDefault => "plan-default",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ProjectSetting => "project-setting",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "elastic-algorithm" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ElasticAlgorithm,
                "plan-default" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.PlanDefault,
                "project-setting" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.ProjectSetting,
                "team-setting" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineSelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}