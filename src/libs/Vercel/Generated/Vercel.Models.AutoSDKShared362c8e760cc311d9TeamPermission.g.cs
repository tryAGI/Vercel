
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared362c8e760cc311d9TeamPermission
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
    public static class AutoSDKShared362c8e760cc311d9TeamPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared362c8e760cc311d9TeamPermission value)
        {
            return value switch
            {
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayBudgetManager => "AiGatewayBudgetManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayCredits => "AiGatewayCredits",
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewaySettings => "AiGatewaySettings",
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayTranscriptsManager => "AiGatewayTranscriptsManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayTranscriptsViewer => "AiGatewayTranscriptsViewer",
                AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayUser => "AiGatewayUser",
                AutoSDKShared362c8e760cc311d9TeamPermission.ConnectorManager => "ConnectorManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.CreateProject => "CreateProject",
                AutoSDKShared362c8e760cc311d9TeamPermission.EnvVariableManager => "EnvVariableManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.EnvironmentManager => "EnvironmentManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.FullProductionDeployment => "FullProductionDeployment",
                AutoSDKShared362c8e760cc311d9TeamPermission.IntegrationManager => "IntegrationManager",
                AutoSDKShared362c8e760cc311d9TeamPermission.OrgAdmin => "OrgAdmin",
                AutoSDKShared362c8e760cc311d9TeamPermission.OrgViewer => "OrgViewer",
                AutoSDKShared362c8e760cc311d9TeamPermission.UsageViewer => "UsageViewer",
                AutoSDKShared362c8e760cc311d9TeamPermission.V0Builder => "V0Builder",
                AutoSDKShared362c8e760cc311d9TeamPermission.V0Chatter => "V0Chatter",
                AutoSDKShared362c8e760cc311d9TeamPermission.V0Viewer => "V0Viewer",
                AutoSDKShared362c8e760cc311d9TeamPermission.WorkflowDecryptor => "WorkflowDecryptor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared362c8e760cc311d9TeamPermission? ToEnum(string value)
        {
            return value switch
            {
                "AiGatewayBudgetManager" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayBudgetManager,
                "AiGatewayCredits" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayCredits,
                "AiGatewaySettings" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewaySettings,
                "AiGatewayTranscriptsManager" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayTranscriptsManager,
                "AiGatewayTranscriptsViewer" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayTranscriptsViewer,
                "AiGatewayUser" => AutoSDKShared362c8e760cc311d9TeamPermission.AiGatewayUser,
                "ConnectorManager" => AutoSDKShared362c8e760cc311d9TeamPermission.ConnectorManager,
                "CreateProject" => AutoSDKShared362c8e760cc311d9TeamPermission.CreateProject,
                "EnvVariableManager" => AutoSDKShared362c8e760cc311d9TeamPermission.EnvVariableManager,
                "EnvironmentManager" => AutoSDKShared362c8e760cc311d9TeamPermission.EnvironmentManager,
                "FullProductionDeployment" => AutoSDKShared362c8e760cc311d9TeamPermission.FullProductionDeployment,
                "IntegrationManager" => AutoSDKShared362c8e760cc311d9TeamPermission.IntegrationManager,
                "OrgAdmin" => AutoSDKShared362c8e760cc311d9TeamPermission.OrgAdmin,
                "OrgViewer" => AutoSDKShared362c8e760cc311d9TeamPermission.OrgViewer,
                "UsageViewer" => AutoSDKShared362c8e760cc311d9TeamPermission.UsageViewer,
                "V0Builder" => AutoSDKShared362c8e760cc311d9TeamPermission.V0Builder,
                "V0Chatter" => AutoSDKShared362c8e760cc311d9TeamPermission.V0Chatter,
                "V0Viewer" => AutoSDKShared362c8e760cc311d9TeamPermission.V0Viewer,
                "WorkflowDecryptor" => AutoSDKShared362c8e760cc311d9TeamPermission.WorkflowDecryptor,
                _ => null,
            };
        }
    }
}