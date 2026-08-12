
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseEmailInviteCodeTeamPermission
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
        /// <summary>
        /// 
        /// </summary>
        WorkflowDecryptor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTeamMembersResponseEmailInviteCodeTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseEmailInviteCodeTeamPermission value)
        {
            return value switch
            {
                GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayApiKeyOwnedBySelf => "AiGatewayApiKeyOwnedBySelf",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.ConnectorManager => "ConnectorManager",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.CreateProject => "CreateProject",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.EnvVariableManager => "EnvVariableManager",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.EnvironmentManager => "EnvironmentManager",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.IntegrationManager => "IntegrationManager",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.OrgAdmin => "OrgAdmin",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.OrgViewer => "OrgViewer",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.UsageViewer => "UsageViewer",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Builder => "V0Builder",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Chatter => "V0Chatter",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Viewer => "V0Viewer",
                GetTeamMembersResponseEmailInviteCodeTeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseEmailInviteCodeTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayApiKeyOwnedBySelf" => GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayApiKeyOwnedBySelf,
                "AiGatewayBudgetManager" => GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => GetTeamMembersResponseEmailInviteCodeTeamPermission.AiGatewaySettings,
                "ConnectorManager" => GetTeamMembersResponseEmailInviteCodeTeamPermission.ConnectorManager,
                "CreateProject" => GetTeamMembersResponseEmailInviteCodeTeamPermission.CreateProject,
                "EnvVariableManager" => GetTeamMembersResponseEmailInviteCodeTeamPermission.EnvVariableManager,
                "EnvironmentManager" => GetTeamMembersResponseEmailInviteCodeTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => GetTeamMembersResponseEmailInviteCodeTeamPermission.FullProductionDeployment,
                "IntegrationManager" => GetTeamMembersResponseEmailInviteCodeTeamPermission.IntegrationManager,
                "OrgAdmin" => GetTeamMembersResponseEmailInviteCodeTeamPermission.OrgAdmin,
                "OrgViewer" => GetTeamMembersResponseEmailInviteCodeTeamPermission.OrgViewer,
                "UsageViewer" => GetTeamMembersResponseEmailInviteCodeTeamPermission.UsageViewer,
                "V0Builder" => GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Builder,
                "V0Chatter" => GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Chatter,
                "V0Viewer" => GetTeamMembersResponseEmailInviteCodeTeamPermission.V0Viewer,
                "WorkflowDecryptor" => GetTeamMembersResponseEmailInviteCodeTeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}