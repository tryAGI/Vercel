
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
        AiGatewayApiKeyOwnedBySelf,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayBudgetManager,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayCredits,
        /// <summary>
        /// 
        /// </summary>
        AiGatewaySettings,
        /// <summary>
        /// 
        /// </summary>
        ConnectorManager,
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
        OrgAdmin,
        /// <summary>
        /// 
        /// </summary>
        OrgViewer,
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
                ReadAccessGroupResponseTeamPermission.AiGatewayApiKeyOwnedBySelf => "AiGatewayApiKeyOwnedBySelf",
                ReadAccessGroupResponseTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                ReadAccessGroupResponseTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                ReadAccessGroupResponseTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                ReadAccessGroupResponseTeamPermission.ConnectorManager => "ConnectorManager",
                ReadAccessGroupResponseTeamPermission.CreateProject => "CreateProject",
                ReadAccessGroupResponseTeamPermission.EnvVariableManager => "EnvVariableManager",
                ReadAccessGroupResponseTeamPermission.EnvironmentManager => "EnvironmentManager",
                ReadAccessGroupResponseTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                ReadAccessGroupResponseTeamPermission.IntegrationManager => "IntegrationManager",
                ReadAccessGroupResponseTeamPermission.OrgAdmin => "OrgAdmin",
                ReadAccessGroupResponseTeamPermission.OrgViewer => "OrgViewer",
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
                "AiGatewayApiKeyOwnedBySelf" => ReadAccessGroupResponseTeamPermission.AiGatewayApiKeyOwnedBySelf,
                "AiGatewayBudgetManager" => ReadAccessGroupResponseTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => ReadAccessGroupResponseTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => ReadAccessGroupResponseTeamPermission.AiGatewaySettings,
                "ConnectorManager" => ReadAccessGroupResponseTeamPermission.ConnectorManager,
                "CreateProject" => ReadAccessGroupResponseTeamPermission.CreateProject,
                "EnvVariableManager" => ReadAccessGroupResponseTeamPermission.EnvVariableManager,
                "EnvironmentManager" => ReadAccessGroupResponseTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => ReadAccessGroupResponseTeamPermission.FullProductionDeployment,
                "IntegrationManager" => ReadAccessGroupResponseTeamPermission.IntegrationManager,
                "OrgAdmin" => ReadAccessGroupResponseTeamPermission.OrgAdmin,
                "OrgViewer" => ReadAccessGroupResponseTeamPermission.OrgViewer,
                "UsageViewer" => ReadAccessGroupResponseTeamPermission.UsageViewer,
                "V0Builder" => ReadAccessGroupResponseTeamPermission.V0Builder,
                "V0Chatter" => ReadAccessGroupResponseTeamPermission.V0Chatter,
                "V0Viewer" => ReadAccessGroupResponseTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}