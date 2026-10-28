
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39b84c098d962a66TeamPermission
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
    public static class AutoSDKShared39b84c098d962a66TeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39b84c098d962a66TeamPermission value)
        {
            return value switch
            {
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayCredits => "AiGatewayCredits",
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewaySettings => "AiGatewaySettings",
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayTranscriptsManager => "AiGatewayTranscriptsManager",
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayTranscriptsViewer => "AiGatewayTranscriptsViewer",
                AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayUser => "AiGatewayUser",
                AutoSDKShared39b84c098d962a66TeamPermission.ConnectorManager => "ConnectorManager",
                AutoSDKShared39b84c098d962a66TeamPermission.CreateProject => "CreateProject",
                AutoSDKShared39b84c098d962a66TeamPermission.EnvVariableManager => "EnvVariableManager",
                AutoSDKShared39b84c098d962a66TeamPermission.EnvironmentManager => "EnvironmentManager",
                AutoSDKShared39b84c098d962a66TeamPermission.FullProductionDeployment => "FullProductionDeployment",
                AutoSDKShared39b84c098d962a66TeamPermission.IntegrationManager => "IntegrationManager",
                AutoSDKShared39b84c098d962a66TeamPermission.OrgAdmin => "OrgAdmin",
                AutoSDKShared39b84c098d962a66TeamPermission.OrgViewer => "OrgViewer",
                AutoSDKShared39b84c098d962a66TeamPermission.UsageViewer => "UsageViewer",
                AutoSDKShared39b84c098d962a66TeamPermission.V0Builder => "V0Builder",
                AutoSDKShared39b84c098d962a66TeamPermission.V0Chatter => "V0Chatter",
                AutoSDKShared39b84c098d962a66TeamPermission.V0Viewer => "V0Viewer",
                AutoSDKShared39b84c098d962a66TeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39b84c098d962a66TeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayBudgetManager" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewaySettings,
                "AiGatewayTranscriptsManager" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayTranscriptsManager,
                "AiGatewayTranscriptsViewer" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayTranscriptsViewer,
                "AiGatewayUser" => AutoSDKShared39b84c098d962a66TeamPermission.AiGatewayUser,
                "ConnectorManager" => AutoSDKShared39b84c098d962a66TeamPermission.ConnectorManager,
                "CreateProject" => AutoSDKShared39b84c098d962a66TeamPermission.CreateProject,
                "EnvVariableManager" => AutoSDKShared39b84c098d962a66TeamPermission.EnvVariableManager,
                "EnvironmentManager" => AutoSDKShared39b84c098d962a66TeamPermission.EnvironmentManager,
                "FullProductionDeployment" => AutoSDKShared39b84c098d962a66TeamPermission.FullProductionDeployment,
                "IntegrationManager" => AutoSDKShared39b84c098d962a66TeamPermission.IntegrationManager,
                "OrgAdmin" => AutoSDKShared39b84c098d962a66TeamPermission.OrgAdmin,
                "OrgViewer" => AutoSDKShared39b84c098d962a66TeamPermission.OrgViewer,
                "UsageViewer" => AutoSDKShared39b84c098d962a66TeamPermission.UsageViewer,
                "V0Builder" => AutoSDKShared39b84c098d962a66TeamPermission.V0Builder,
                "V0Chatter" => AutoSDKShared39b84c098d962a66TeamPermission.V0Chatter,
                "V0Viewer" => AutoSDKShared39b84c098d962a66TeamPermission.V0Viewer,
                "WorkflowDecryptor" => AutoSDKShared39b84c098d962a66TeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}