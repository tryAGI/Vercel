
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerTeamTeamPermission
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
    public static class UserEventPayloadVariant116NewOwnerTeamTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerTeamTeamPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.CreateProject => "CreateProject",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.EnvVariableManager => "EnvVariableManager",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.EnvironmentManager => "EnvironmentManager",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.IntegrationManager => "IntegrationManager",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.UsageViewer => "UsageViewer",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Builder => "V0Builder",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Chatter => "V0Chatter",
                UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerTeamTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.CreateProject,
                "EnvVariableManager" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.EnvVariableManager,
                "EnvironmentManager" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.FullProductionDeployment,
                "IntegrationManager" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.IntegrationManager,
                "UsageViewer" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.UsageViewer,
                "V0Builder" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Builder,
                "V0Chatter" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Chatter,
                "V0Viewer" => UserEventPayloadVariant116NewOwnerTeamTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}