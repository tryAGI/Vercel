
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamLimitedMembershipTeamPermission
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
    public static class TeamLimitedMembershipTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedMembershipTeamPermission value)
        {
            return value switch
            {
                TeamLimitedMembershipTeamPermission.CreateProject => "CreateProject",
                TeamLimitedMembershipTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamLimitedMembershipTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamLimitedMembershipTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamLimitedMembershipTeamPermission.IntegrationManager => "IntegrationManager",
                TeamLimitedMembershipTeamPermission.UsageViewer => "UsageViewer",
                TeamLimitedMembershipTeamPermission.V0Builder => "V0Builder",
                TeamLimitedMembershipTeamPermission.V0Chatter => "V0Chatter",
                TeamLimitedMembershipTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedMembershipTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => TeamLimitedMembershipTeamPermission.CreateProject,
                "EnvVariableManager" => TeamLimitedMembershipTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamLimitedMembershipTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamLimitedMembershipTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamLimitedMembershipTeamPermission.IntegrationManager,
                "UsageViewer" => TeamLimitedMembershipTeamPermission.UsageViewer,
                "V0Builder" => TeamLimitedMembershipTeamPermission.V0Builder,
                "V0Chatter" => TeamLimitedMembershipTeamPermission.V0Chatter,
                "V0Viewer" => TeamLimitedMembershipTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}