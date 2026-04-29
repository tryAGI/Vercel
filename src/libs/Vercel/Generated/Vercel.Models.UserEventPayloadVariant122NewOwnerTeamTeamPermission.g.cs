
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerTeamTeamPermission
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
    public static class UserEventPayloadVariant122NewOwnerTeamTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerTeamTeamPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.CreateProject => "CreateProject",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.EnvVariableManager => "EnvVariableManager",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.EnvironmentManager => "EnvironmentManager",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.IntegrationManager => "IntegrationManager",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.UsageViewer => "UsageViewer",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Builder => "V0Builder",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Chatter => "V0Chatter",
                UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerTeamTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.CreateProject,
                "EnvVariableManager" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.EnvVariableManager,
                "EnvironmentManager" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.FullProductionDeployment,
                "IntegrationManager" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.IntegrationManager,
                "UsageViewer" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.UsageViewer,
                "V0Builder" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Builder,
                "V0Chatter" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Chatter,
                "V0Viewer" => UserEventPayloadVariant122NewOwnerTeamTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}