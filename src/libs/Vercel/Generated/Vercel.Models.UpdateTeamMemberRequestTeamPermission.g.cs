
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateTeamMemberRequestTeamPermission
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
    public static class UpdateTeamMemberRequestTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTeamMemberRequestTeamPermission value)
        {
            return value switch
            {
                UpdateTeamMemberRequestTeamPermission.CreateProject => "CreateProject",
                UpdateTeamMemberRequestTeamPermission.EnvVariableManager => "EnvVariableManager",
                UpdateTeamMemberRequestTeamPermission.EnvironmentManager => "EnvironmentManager",
                UpdateTeamMemberRequestTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                UpdateTeamMemberRequestTeamPermission.IntegrationManager => "IntegrationManager",
                UpdateTeamMemberRequestTeamPermission.UsageViewer => "UsageViewer",
                UpdateTeamMemberRequestTeamPermission.V0Builder => "V0Builder",
                UpdateTeamMemberRequestTeamPermission.V0Chatter => "V0Chatter",
                UpdateTeamMemberRequestTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTeamMemberRequestTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => UpdateTeamMemberRequestTeamPermission.CreateProject,
                "EnvVariableManager" => UpdateTeamMemberRequestTeamPermission.EnvVariableManager,
                "EnvironmentManager" => UpdateTeamMemberRequestTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => UpdateTeamMemberRequestTeamPermission.FullProductionDeployment,
                "IntegrationManager" => UpdateTeamMemberRequestTeamPermission.IntegrationManager,
                "UsageViewer" => UpdateTeamMemberRequestTeamPermission.UsageViewer,
                "V0Builder" => UpdateTeamMemberRequestTeamPermission.V0Builder,
                "V0Chatter" => UpdateTeamMemberRequestTeamPermission.V0Chatter,
                "V0Viewer" => UpdateTeamMemberRequestTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}