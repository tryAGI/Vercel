
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The team permissions of the user<br/>
    /// Example: [CreateProject]
    /// </summary>
    public enum InvitedTeamMemberTeamPermission
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
    public static class InvitedTeamMemberTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvitedTeamMemberTeamPermission value)
        {
            return value switch
            {
                InvitedTeamMemberTeamPermission.AiGatewayApiKeyOwnedBySelf => "AiGatewayApiKeyOwnedBySelf",
                InvitedTeamMemberTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                InvitedTeamMemberTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                InvitedTeamMemberTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                InvitedTeamMemberTeamPermission.CreateProject => "CreateProject",
                InvitedTeamMemberTeamPermission.EnvVariableManager => "EnvVariableManager",
                InvitedTeamMemberTeamPermission.EnvironmentManager => "EnvironmentManager",
                InvitedTeamMemberTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                InvitedTeamMemberTeamPermission.IntegrationManager => "IntegrationManager",
                InvitedTeamMemberTeamPermission.OrgAdmin => "OrgAdmin",
                InvitedTeamMemberTeamPermission.OrgViewer => "OrgViewer",
                InvitedTeamMemberTeamPermission.UsageViewer => "UsageViewer",
                InvitedTeamMemberTeamPermission.V0Builder => "V0Builder",
                InvitedTeamMemberTeamPermission.V0Chatter => "V0Chatter",
                InvitedTeamMemberTeamPermission.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvitedTeamMemberTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayApiKeyOwnedBySelf" => InvitedTeamMemberTeamPermission.AiGatewayApiKeyOwnedBySelf,
                "AiGatewayBudgetManager" => InvitedTeamMemberTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => InvitedTeamMemberTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => InvitedTeamMemberTeamPermission.AiGatewaySettings,
                "CreateProject" => InvitedTeamMemberTeamPermission.CreateProject,
                "EnvVariableManager" => InvitedTeamMemberTeamPermission.EnvVariableManager,
                "EnvironmentManager" => InvitedTeamMemberTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => InvitedTeamMemberTeamPermission.FullProductionDeployment,
                "IntegrationManager" => InvitedTeamMemberTeamPermission.IntegrationManager,
                "OrgAdmin" => InvitedTeamMemberTeamPermission.OrgAdmin,
                "OrgViewer" => InvitedTeamMemberTeamPermission.OrgViewer,
                "UsageViewer" => InvitedTeamMemberTeamPermission.UsageViewer,
                "V0Builder" => InvitedTeamMemberTeamPermission.V0Builder,
                "V0Chatter" => InvitedTeamMemberTeamPermission.V0Chatter,
                "V0Viewer" => InvitedTeamMemberTeamPermission.V0Viewer,
                _ => null,
            };
        }
    }
}