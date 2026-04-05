
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemIntegrationTagId
    {
        /// <summary>
        /// 
        /// </summary>
        TagAgents,
        /// <summary>
        /// 
        /// </summary>
        TagAi,
        /// <summary>
        /// 
        /// </summary>
        TagAnalytics,
        /// <summary>
        /// 
        /// </summary>
        TagAuthentication,
        /// <summary>
        /// 
        /// </summary>
        TagCms,
        /// <summary>
        /// 
        /// </summary>
        TagCodeRepository,
        /// <summary>
        /// 
        /// </summary>
        TagCodeReview,
        /// <summary>
        /// 
        /// </summary>
        TagCodeSecurity,
        /// <summary>
        /// 
        /// </summary>
        TagCodeTesting,
        /// <summary>
        /// 
        /// </summary>
        TagCommerce,
        /// <summary>
        /// 
        /// </summary>
        TagDatabases,
        /// <summary>
        /// 
        /// </summary>
        TagDevTools,
        /// <summary>
        /// 
        /// </summary>
        TagExperimentation,
        /// <summary>
        /// 
        /// </summary>
        TagFlags,
        /// <summary>
        /// 
        /// </summary>
        TagLogging,
        /// <summary>
        /// 
        /// </summary>
        TagMessaging,
        /// <summary>
        /// 
        /// </summary>
        TagMonitoring,
        /// <summary>
        /// 
        /// </summary>
        TagObservability,
        /// <summary>
        /// 
        /// </summary>
        TagPayments,
        /// <summary>
        /// 
        /// </summary>
        TagPerformance,
        /// <summary>
        /// 
        /// </summary>
        TagProductivity,
        /// <summary>
        /// 
        /// </summary>
        TagSearching,
        /// <summary>
        /// 
        /// </summary>
        TagSecurity,
        /// <summary>
        /// 
        /// </summary>
        TagSupportAgent,
        /// <summary>
        /// 
        /// </summary>
        TagTesting,
        /// <summary>
        /// 
        /// </summary>
        TagVideo,
        /// <summary>
        /// 
        /// </summary>
        TagWebAutomation,
        /// <summary>
        /// 
        /// </summary>
        TagWorkflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsResponseVariant2ItemIntegrationTagIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemIntegrationTagId value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAgents => "tag_agents",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAi => "tag_ai",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAnalytics => "tag_analytics",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAuthentication => "tag_authentication",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCms => "tag_cms",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeRepository => "tag_code_repository",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeReview => "tag_code_review",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeSecurity => "tag_code_security",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeTesting => "tag_code_testing",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCommerce => "tag_commerce",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagDatabases => "tag_databases",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagDevTools => "tag_dev_tools",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagExperimentation => "tag_experimentation",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagFlags => "tag_flags",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagLogging => "tag_logging",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagMessaging => "tag_messaging",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagMonitoring => "tag_monitoring",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagObservability => "tag_observability",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagPayments => "tag_payments",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagPerformance => "tag_performance",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagProductivity => "tag_productivity",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSearching => "tag_searching",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSecurity => "tag_security",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSupportAgent => "tag_support_agent",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagTesting => "tag_testing",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagVideo => "tag_video",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagWebAutomation => "tag_web_automation",
                GetConfigurationsResponseVariant2ItemIntegrationTagId.TagWorkflow => "tag_workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemIntegrationTagId? ToEnum(string value)
        {
            return value switch
            {
                "tag_agents" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAgents,
                "tag_ai" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAi,
                "tag_analytics" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAnalytics,
                "tag_authentication" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagAuthentication,
                "tag_cms" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCms,
                "tag_code_repository" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeRepository,
                "tag_code_review" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeReview,
                "tag_code_security" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeSecurity,
                "tag_code_testing" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCodeTesting,
                "tag_commerce" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagCommerce,
                "tag_databases" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagDatabases,
                "tag_dev_tools" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagDevTools,
                "tag_experimentation" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagExperimentation,
                "tag_flags" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagFlags,
                "tag_logging" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagLogging,
                "tag_messaging" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagMessaging,
                "tag_monitoring" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagMonitoring,
                "tag_observability" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagObservability,
                "tag_payments" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagPayments,
                "tag_performance" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagPerformance,
                "tag_productivity" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagProductivity,
                "tag_searching" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSearching,
                "tag_security" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSecurity,
                "tag_support_agent" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagSupportAgent,
                "tag_testing" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagTesting,
                "tag_video" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagVideo,
                "tag_web_automation" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagWebAutomation,
                "tag_workflow" => GetConfigurationsResponseVariant2ItemIntegrationTagId.TagWorkflow,
                _ => null,
            };
        }
    }
}