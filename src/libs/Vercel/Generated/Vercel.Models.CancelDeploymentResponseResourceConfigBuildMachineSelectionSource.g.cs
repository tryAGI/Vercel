
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
    /// </summary>
    public enum CancelDeploymentResponseResourceConfigBuildMachineSelectionSource
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
    public static class CancelDeploymentResponseResourceConfigBuildMachineSelectionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseResourceConfigBuildMachineSelectionSource value)
        {
            return value switch
            {
                CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.ElasticAlgorithm => "elastic-algorithm",
                CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.PlanDefault => "plan-default",
                CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.ProjectSetting => "project-setting",
                CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamSetting => "team-setting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseResourceConfigBuildMachineSelectionSource? ToEnum(string value)
        {
            return value switch
            {
                "elastic-algorithm" => CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.ElasticAlgorithm,
                "plan-default" => CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.PlanDefault,
                "project-setting" => CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.ProjectSetting,
                "team-setting" => CancelDeploymentResponseResourceConfigBuildMachineSelectionSource.TeamSetting,
                _ => null,
            };
        }
    }
}