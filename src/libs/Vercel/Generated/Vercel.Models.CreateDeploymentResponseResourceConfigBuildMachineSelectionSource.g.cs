
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum CreateDeploymentResponseResourceConfigBuildMachineSelectionSource
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
    public static class CreateDeploymentResponseResourceConfigBuildMachineSelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseResourceConfigBuildMachineSelectionSource value)
        {
            return value switch
            {
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.DeploymentOverride => "deployment-override",
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.ElasticAlgorithm => "elastic-algorithm",
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.PlanDefault => "plan-default",
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.ProjectSetting => "project-setting",
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamEntitlement => "team-entitlement",
                CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseResourceConfigBuildMachineSelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "deployment-override" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.DeploymentOverride,
                "elastic-algorithm" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.ElasticAlgorithm,
                "plan-default" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.PlanDefault,
                "project-setting" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.ProjectSetting,
                "team-entitlement" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamEntitlement,
                "team-setting" => CreateDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}