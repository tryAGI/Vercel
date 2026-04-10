
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerTeamTeamPermission
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
    public static class UserEventPayloadVariant115NewOwnerTeamTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerTeamTeamPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.CreateProject => "CreateProject",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.EnvVariableManager => "EnvVariableManager",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.EnvironmentManager => "EnvironmentManager",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.IntegrationManager => "IntegrationManager",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.UsageViewer => "UsageViewer",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Builder => "V0Builder",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Chatter => "V0Chatter",
                UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerTeamTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.CreateProject,
                "EnvVariableManager" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.EnvVariableManager,
                "EnvironmentManager" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.FullProductionDeployment,
                "IntegrationManager" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.IntegrationManager,
                "UsageViewer" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.UsageViewer,
                "V0Builder" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Builder,
                "V0Chatter" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Chatter,
                "V0Viewer" => UserEventPayloadVariant115NewOwnerTeamTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}