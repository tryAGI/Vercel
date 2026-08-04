
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
    public static class TeamLimitedMembershipTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedMembershipTeamPermission value)
        {
            return value switch
            {
                TeamLimitedMembershipTeamPermission.AiGatewayApiKeyOwnedBySelf => "AiGatewayApiKeyOwnedBySelf",
                TeamLimitedMembershipTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                TeamLimitedMembershipTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                TeamLimitedMembershipTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                TeamLimitedMembershipTeamPermission.ConnectorManager => "ConnectorManager",
                TeamLimitedMembershipTeamPermission.CreateProject => "CreateProject",
                TeamLimitedMembershipTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamLimitedMembershipTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamLimitedMembershipTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamLimitedMembershipTeamPermission.IntegrationManager => "IntegrationManager",
                TeamLimitedMembershipTeamPermission.OrgAdmin => "OrgAdmin",
                TeamLimitedMembershipTeamPermission.OrgViewer => "OrgViewer",
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
                "AiGatewayApiKeyOwnedBySelf" => TeamLimitedMembershipTeamPermission.AiGatewayApiKeyOwnedBySelf,
                "AiGatewayBudgetManager" => TeamLimitedMembershipTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => TeamLimitedMembershipTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => TeamLimitedMembershipTeamPermission.AiGatewaySettings,
                "ConnectorManager" => TeamLimitedMembershipTeamPermission.ConnectorManager,
                "CreateProject" => TeamLimitedMembershipTeamPermission.CreateProject,
                "EnvVariableManager" => TeamLimitedMembershipTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamLimitedMembershipTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamLimitedMembershipTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamLimitedMembershipTeamPermission.IntegrationManager,
                "OrgAdmin" => TeamLimitedMembershipTeamPermission.OrgAdmin,
                "OrgViewer" => TeamLimitedMembershipTeamPermission.OrgViewer,
                "UsageViewer" => TeamLimitedMembershipTeamPermission.UsageViewer,
                "V0Builder" => TeamLimitedMembershipTeamPermission.V0Builder,
                "V0Chatter" => TeamLimitedMembershipTeamPermission.V0Chatter,
                "V0Viewer" => TeamLimitedMembershipTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}