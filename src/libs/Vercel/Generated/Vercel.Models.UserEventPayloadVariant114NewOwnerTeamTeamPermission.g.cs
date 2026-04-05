
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerTeamTeamPermission
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
    public static class UserEventPayloadVariant114NewOwnerTeamTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerTeamTeamPermission value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.CreateProject => "CreateProject",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.EnvVariableManager => "EnvVariableManager",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.EnvironmentManager => "EnvironmentManager",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.IntegrationManager => "IntegrationManager",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.UsageViewer => "UsageViewer",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Builder => "V0Builder",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Chatter => "V0Chatter",
                UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerTeamTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "CreateProject" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.CreateProject,
                "EnvVariableManager" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.EnvVariableManager,
                "EnvironmentManager" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.FullProductionDeployment,
                "IntegrationManager" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.IntegrationManager,
                "UsageViewer" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.UsageViewer,
                "V0Builder" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Builder,
                "V0Chatter" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Chatter,
                "V0Viewer" => UserEventPayloadVariant114NewOwnerTeamTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}