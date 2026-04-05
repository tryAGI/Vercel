
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDefaultRolesTeamPermission
    {
        /// <summary>
        /// 
        /// </summary>
        CreateProject,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableManager,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentManager,
        /// <summary>
        /// 
        /// </summary>
        FullProductionDeployment,
        /// <summary>
        /// 
        /// </summary>
        IntegrationManager,
        /// <summary>
        /// 
        /// </summary>
        UsageViewer,
        /// <summary>
        /// 
        /// </summary>
        V0Builder,
        /// <summary>
        /// 
        /// </summary>
        V0Chatter,
        /// <summary>
        /// 
        /// </summary>
        V0Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDefaultRolesTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDefaultRolesTeamPermission value)
        {
            return value switch
            {
                TeamDefaultRolesTeamPermission.CreateProject => "CreateProject",
                TeamDefaultRolesTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamDefaultRolesTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamDefaultRolesTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamDefaultRolesTeamPermission.IntegrationManager => "IntegrationManager",
                TeamDefaultRolesTeamPermission.UsageViewer => "UsageViewer",
                TeamDefaultRolesTeamPermission.V0Builder => "V0Builder",
                TeamDefaultRolesTeamPermission.V0Chatter => "V0Chatter",
                TeamDefaultRolesTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDefaultRolesTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => TeamDefaultRolesTeamPermission.CreateProject,
                "EnvVariableManager" => TeamDefaultRolesTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamDefaultRolesTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamDefaultRolesTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamDefaultRolesTeamPermission.IntegrationManager,
                "UsageViewer" => TeamDefaultRolesTeamPermission.UsageViewer,
                "V0Builder" => TeamDefaultRolesTeamPermission.V0Builder,
                "V0Chatter" => TeamDefaultRolesTeamPermission.V0Chatter,
                "V0Viewer" => TeamDefaultRolesTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}