
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamSamlRolesEnumTeamPermission
    {
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
        AiGatewayUser,
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
    public static class TeamSamlRolesEnumTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlRolesEnumTeamPermission value)
        {
            return value switch
            {
                TeamSamlRolesEnumTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                TeamSamlRolesEnumTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                TeamSamlRolesEnumTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                TeamSamlRolesEnumTeamPermission.AiGatewayTranscriptsManager => "AiGatewayTranscriptsManager",
                TeamSamlRolesEnumTeamPermission.AiGatewayTranscriptsViewer => "AiGatewayTranscriptsViewer",
                TeamSamlRolesEnumTeamPermission.AiGatewayUser => "AiGatewayUser",
                TeamSamlRolesEnumTeamPermission.ConnectorManager => "ConnectorManager",
                TeamSamlRolesEnumTeamPermission.CreateProject => "CreateProject",
                TeamSamlRolesEnumTeamPermission.EnvVariableManager => "EnvVariableManager",
                TeamSamlRolesEnumTeamPermission.EnvironmentManager => "EnvironmentManager",
                TeamSamlRolesEnumTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                TeamSamlRolesEnumTeamPermission.IntegrationManager => "IntegrationManager",
                TeamSamlRolesEnumTeamPermission.OrgAdmin => "OrgAdmin",
                TeamSamlRolesEnumTeamPermission.OrgViewer => "OrgViewer",
                TeamSamlRolesEnumTeamPermission.UsageViewer => "UsageViewer",
                TeamSamlRolesEnumTeamPermission.V0Builder => "V0Builder",
                TeamSamlRolesEnumTeamPermission.V0Chatter => "V0Chatter",
                TeamSamlRolesEnumTeamPermission.V0Viewer => "V0Viewer",
                TeamSamlRolesEnumTeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlRolesEnumTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayBudgetManager" => TeamSamlRolesEnumTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => TeamSamlRolesEnumTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => TeamSamlRolesEnumTeamPermission.AiGatewaySettings,
                "AiGatewayTranscriptsManager" => TeamSamlRolesEnumTeamPermission.AiGatewayTranscriptsManager,
                "AiGatewayTranscriptsViewer" => TeamSamlRolesEnumTeamPermission.AiGatewayTranscriptsViewer,
                "AiGatewayUser" => TeamSamlRolesEnumTeamPermission.AiGatewayUser,
                "ConnectorManager" => TeamSamlRolesEnumTeamPermission.ConnectorManager,
                "CreateProject" => TeamSamlRolesEnumTeamPermission.CreateProject,
                "EnvVariableManager" => TeamSamlRolesEnumTeamPermission.EnvVariableManager,
                "EnvironmentManager" => TeamSamlRolesEnumTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => TeamSamlRolesEnumTeamPermission.FullProductionDeployment,
                "IntegrationManager" => TeamSamlRolesEnumTeamPermission.IntegrationManager,
                "OrgAdmin" => TeamSamlRolesEnumTeamPermission.OrgAdmin,
                "OrgViewer" => TeamSamlRolesEnumTeamPermission.OrgViewer,
                "UsageViewer" => TeamSamlRolesEnumTeamPermission.UsageViewer,
                "V0Builder" => TeamSamlRolesEnumTeamPermission.V0Builder,
                "V0Chatter" => TeamSamlRolesEnumTeamPermission.V0Chatter,
                "V0Viewer" => TeamSamlRolesEnumTeamPermission.V0Viewer,
                "WorkflowDecryptor" => TeamSamlRolesEnumTeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}