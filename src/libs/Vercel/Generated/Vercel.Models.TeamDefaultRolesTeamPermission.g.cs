
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamDefaultRolesTeamPermission
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
        AiGatewayTranscriptsManager,
        /// <summary>
        ///
        /// </summary>
        AiGatewayTranscriptsViewer,
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
    public static class TeamDefaultRolesTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDefaultRolesTeamPermission value)
        {
            return value switch
            {
                TeamDefaultRolesTeamPermission.AiGatewayApiKeyOwnedBySelf => "AiGatewayApiKeyOwnedBySelf",
                TeamDefaultRolesTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                TeamDefaultRolesTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                TeamDefaultRolesTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                TeamDefaultRolesTeamPermission.AiGatewayTranscriptsManager => "AiGatewayTranscriptsManager",
                TeamDefaultRolesTeamPermission.AiGatewayTranscriptsViewer => "AiGatewayTranscriptsViewer",
                TeamDefaultRolesTeamPermission.ConnectorManager => "ConnectorManager",
                TeamDefaultRolesTeamPermission.CreateProject => "CreateProject",
                TeamDefaultRolesTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamDefaultRolesTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamDefaultRolesTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamDefaultRolesTeamPermission.IntegrationManager => "IntegrationManager",
                TeamDefaultRolesTeamPermission.OrgAdmin => "OrgAdmin",
                TeamDefaultRolesTeamPermission.OrgViewer => "OrgViewer",
                TeamDefaultRolesTeamPermission.UsageViewer => "UsageViewer",
                TeamDefaultRolesTeamPermission.V0Builder => "V0Builder",
                TeamDefaultRolesTeamPermission.V0Chatter => "V0Chatter",
                TeamDefaultRolesTeamPermission.V0Viewer => "V0Viewer",
                TeamDefaultRolesTeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDefaultRolesTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayApiKeyOwnedBySelf" => TeamDefaultRolesTeamPermission.AiGatewayApiKeyOwnedBySelf,
                "AiGatewayBudgetManager" => TeamDefaultRolesTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => TeamDefaultRolesTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => TeamDefaultRolesTeamPermission.AiGatewaySettings,
                "AiGatewayTranscriptsManager" => TeamDefaultRolesTeamPermission.AiGatewayTranscriptsManager,
                "AiGatewayTranscriptsViewer" => TeamDefaultRolesTeamPermission.AiGatewayTranscriptsViewer,
                "ConnectorManager" => TeamDefaultRolesTeamPermission.ConnectorManager,
                "CreateProject" => TeamDefaultRolesTeamPermission.CreateProject,
                "EnvVariableManager" => TeamDefaultRolesTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamDefaultRolesTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamDefaultRolesTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamDefaultRolesTeamPermission.IntegrationManager,
                "OrgAdmin" => TeamDefaultRolesTeamPermission.OrgAdmin,
                "OrgViewer" => TeamDefaultRolesTeamPermission.OrgViewer,
                "UsageViewer" => TeamDefaultRolesTeamPermission.UsageViewer,
                "V0Builder" => TeamDefaultRolesTeamPermission.V0Builder,
                "V0Chatter" => TeamDefaultRolesTeamPermission.V0Chatter,
                "V0Viewer" => TeamDefaultRolesTeamPermission.V0Viewer,
                "WorkflowDecryptor" => TeamDefaultRolesTeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}