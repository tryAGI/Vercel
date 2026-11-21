
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5dd9960a4fc82febTeamPermission
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
    public static class AutoSDKShared5dd9960a4fc82febTeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5dd9960a4fc82febTeamPermission value)
        {
            return value switch
            {
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayCredits => "AiGatewayCredits",
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewaySettings => "AiGatewaySettings",
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayTranscriptsManager => "AiGatewayTranscriptsManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayTranscriptsViewer => "AiGatewayTranscriptsViewer",
                AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayUser => "AiGatewayUser",
                AutoSDKShared5dd9960a4fc82febTeamPermission.ConnectorManager => "ConnectorManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.CreateProject => "CreateProject",
                AutoSDKShared5dd9960a4fc82febTeamPermission.EnvVariableManager => "EnvVariableManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.EnvironmentManager => "EnvironmentManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.FullProductionDeployment => "FullProductionDeployment",
                AutoSDKShared5dd9960a4fc82febTeamPermission.IntegrationManager => "IntegrationManager",
                AutoSDKShared5dd9960a4fc82febTeamPermission.OrgAdmin => "OrgAdmin",
                AutoSDKShared5dd9960a4fc82febTeamPermission.OrgViewer => "OrgViewer",
                AutoSDKShared5dd9960a4fc82febTeamPermission.UsageViewer => "UsageViewer",
                AutoSDKShared5dd9960a4fc82febTeamPermission.V0Builder => "V0Builder",
                AutoSDKShared5dd9960a4fc82febTeamPermission.V0Chatter => "V0Chatter",
                AutoSDKShared5dd9960a4fc82febTeamPermission.V0Viewer => "V0Viewer",
                AutoSDKShared5dd9960a4fc82febTeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5dd9960a4fc82febTeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayBudgetManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewaySettings,
                "AiGatewayTranscriptsManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayTranscriptsManager,
                "AiGatewayTranscriptsViewer" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayTranscriptsViewer,
                "AiGatewayUser" => AutoSDKShared5dd9960a4fc82febTeamPermission.AiGatewayUser,
                "ConnectorManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.ConnectorManager,
                "CreateProject" => AutoSDKShared5dd9960a4fc82febTeamPermission.CreateProject,
                "EnvVariableManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.EnvVariableManager,
                "EnvironmentManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.EnvironmentManager,
                "FullProductionDeployment" => AutoSDKShared5dd9960a4fc82febTeamPermission.FullProductionDeployment,
                "IntegrationManager" => AutoSDKShared5dd9960a4fc82febTeamPermission.IntegrationManager,
                "OrgAdmin" => AutoSDKShared5dd9960a4fc82febTeamPermission.OrgAdmin,
                "OrgViewer" => AutoSDKShared5dd9960a4fc82febTeamPermission.OrgViewer,
                "UsageViewer" => AutoSDKShared5dd9960a4fc82febTeamPermission.UsageViewer,
                "V0Builder" => AutoSDKShared5dd9960a4fc82febTeamPermission.V0Builder,
                "V0Chatter" => AutoSDKShared5dd9960a4fc82febTeamPermission.V0Chatter,
                "V0Viewer" => AutoSDKShared5dd9960a4fc82febTeamPermission.V0Viewer,
                "WorkflowDecryptor" => AutoSDKShared5dd9960a4fc82febTeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}