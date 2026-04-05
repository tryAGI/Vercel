
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamMembershipTeamPermission
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
    public static class TeamMembershipTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipTeamPermission value)
        {
            return value switch
            {
                TeamMembershipTeamPermission.CreateProject => "CreateProject",
                TeamMembershipTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamMembershipTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamMembershipTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamMembershipTeamPermission.IntegrationManager => "IntegrationManager",
                TeamMembershipTeamPermission.UsageViewer => "UsageViewer",
                TeamMembershipTeamPermission.V0Builder => "V0Builder",
                TeamMembershipTeamPermission.V0Chatter => "V0Chatter",
                TeamMembershipTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => TeamMembershipTeamPermission.CreateProject,
                "EnvVariableManager" => TeamMembershipTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamMembershipTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamMembershipTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamMembershipTeamPermission.IntegrationManager,
                "UsageViewer" => TeamMembershipTeamPermission.UsageViewer,
                "V0Builder" => TeamMembershipTeamPermission.V0Builder,
                "V0Chatter" => TeamMembershipTeamPermission.V0Chatter,
                "V0Viewer" => TeamMembershipTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}