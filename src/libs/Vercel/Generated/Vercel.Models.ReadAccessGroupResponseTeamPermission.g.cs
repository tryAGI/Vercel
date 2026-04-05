
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadAccessGroupResponseTeamPermission
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
    public static class ReadAccessGroupResponseTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadAccessGroupResponseTeamPermission value)
        {
            return value switch
            {
                ReadAccessGroupResponseTeamPermission.CreateProject => "CreateProject",
                ReadAccessGroupResponseTeamPermission.EnvVariableManager => "EnvVariableManager",
                ReadAccessGroupResponseTeamPermission.EnvironmentManager => "EnvironmentManager",
                ReadAccessGroupResponseTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                ReadAccessGroupResponseTeamPermission.IntegrationManager => "IntegrationManager",
                ReadAccessGroupResponseTeamPermission.UsageViewer => "UsageViewer",
                ReadAccessGroupResponseTeamPermission.V0Builder => "V0Builder",
                ReadAccessGroupResponseTeamPermission.V0Chatter => "V0Chatter",
                ReadAccessGroupResponseTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadAccessGroupResponseTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => ReadAccessGroupResponseTeamPermission.CreateProject,
                "EnvVariableManager" => ReadAccessGroupResponseTeamPermission.EnvVariableManager,
                "EnvironmentManager" => ReadAccessGroupResponseTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => ReadAccessGroupResponseTeamPermission.FullProductionDeployment,
                "IntegrationManager" => ReadAccessGroupResponseTeamPermission.IntegrationManager,
                "UsageViewer" => ReadAccessGroupResponseTeamPermission.UsageViewer,
                "V0Builder" => ReadAccessGroupResponseTeamPermission.V0Builder,
                "V0Chatter" => ReadAccessGroupResponseTeamPermission.V0Chatter,
                "V0Viewer" => ReadAccessGroupResponseTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}