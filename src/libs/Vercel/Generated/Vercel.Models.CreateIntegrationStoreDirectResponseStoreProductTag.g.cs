
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductTag
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Authentication,
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        Checks,
        /// <summary>
        /// 
        /// </summary>
        Drains,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfig,
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
        /// <summary>
        /// 
        /// </summary>
        Kv,
        /// <summary>
        /// 
        /// </summary>
        Libsql,
        /// <summary>
        /// 
        /// </summary>
        LogDrain,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Messaging,
        /// <summary>
        /// 
        /// </summary>
        Mysql,
        /// <summary>
        /// 
        /// </summary>
        Observability,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Postgres,
        /// <summary>
        /// 
        /// </summary>
        Rds,
        /// <summary>
        /// 
        /// </summary>
        Redis,
        /// <summary>
        /// 
        /// </summary>
        Sqlite,
        /// <summary>
        /// 
        /// </summary>
        Storage,
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
        TagChecks,
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
        TagLogDrain,
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
        TagOther,
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
        TagStorage,
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
        TagTraceDrain,
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
        /// <summary>
        /// 
        /// </summary>
        TraceDrain,
        /// <summary>
        /// 
        /// </summary>
        Vector,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductTag value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductTag.Ai => "ai",
                CreateIntegrationStoreDirectResponseStoreProductTag.Authentication => "authentication",
                CreateIntegrationStoreDirectResponseStoreProductTag.Blob => "blob",
                CreateIntegrationStoreDirectResponseStoreProductTag.Checks => "checks",
                CreateIntegrationStoreDirectResponseStoreProductTag.Drains => "drains",
                CreateIntegrationStoreDirectResponseStoreProductTag.EdgeConfig => "edge-config",
                CreateIntegrationStoreDirectResponseStoreProductTag.Experimentation => "experimentation",
                CreateIntegrationStoreDirectResponseStoreProductTag.Kv => "kv",
                CreateIntegrationStoreDirectResponseStoreProductTag.Libsql => "libsql",
                CreateIntegrationStoreDirectResponseStoreProductTag.LogDrain => "logDrain",
                CreateIntegrationStoreDirectResponseStoreProductTag.Mcp => "mcp",
                CreateIntegrationStoreDirectResponseStoreProductTag.Messaging => "messaging",
                CreateIntegrationStoreDirectResponseStoreProductTag.Mysql => "mysql",
                CreateIntegrationStoreDirectResponseStoreProductTag.Observability => "observability",
                CreateIntegrationStoreDirectResponseStoreProductTag.Other => "other",
                CreateIntegrationStoreDirectResponseStoreProductTag.Postgres => "postgres",
                CreateIntegrationStoreDirectResponseStoreProductTag.Rds => "rds",
                CreateIntegrationStoreDirectResponseStoreProductTag.Redis => "redis",
                CreateIntegrationStoreDirectResponseStoreProductTag.Sqlite => "sqlite",
                CreateIntegrationStoreDirectResponseStoreProductTag.Storage => "storage",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagAgents => "tag_agents",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagAi => "tag_ai",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagAnalytics => "tag_analytics",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagAuthentication => "tag_authentication",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagChecks => "tag_checks",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCms => "tag_cms",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeRepository => "tag_code_repository",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeReview => "tag_code_review",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeSecurity => "tag_code_security",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeTesting => "tag_code_testing",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagCommerce => "tag_commerce",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagDatabases => "tag_databases",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagDevTools => "tag_dev_tools",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagExperimentation => "tag_experimentation",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagFlags => "tag_flags",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagLogDrain => "tag_logDrain",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagLogging => "tag_logging",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagMessaging => "tag_messaging",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagMonitoring => "tag_monitoring",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagObservability => "tag_observability",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagOther => "tag_other",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagPayments => "tag_payments",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagPerformance => "tag_performance",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagProductivity => "tag_productivity",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagSearching => "tag_searching",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagSecurity => "tag_security",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagStorage => "tag_storage",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagSupportAgent => "tag_support_agent",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagTesting => "tag_testing",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagTraceDrain => "tag_traceDrain",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagVideo => "tag_video",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagWebAutomation => "tag_web_automation",
                CreateIntegrationStoreDirectResponseStoreProductTag.TagWorkflow => "tag_workflow",
                CreateIntegrationStoreDirectResponseStoreProductTag.TraceDrain => "traceDrain",
                CreateIntegrationStoreDirectResponseStoreProductTag.Vector => "vector",
                CreateIntegrationStoreDirectResponseStoreProductTag.Video => "video",
                CreateIntegrationStoreDirectResponseStoreProductTag.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductTag? ToEnum(string value)
        {
            return value switch
            {
                "ai" => CreateIntegrationStoreDirectResponseStoreProductTag.Ai,
                "authentication" => CreateIntegrationStoreDirectResponseStoreProductTag.Authentication,
                "blob" => CreateIntegrationStoreDirectResponseStoreProductTag.Blob,
                "checks" => CreateIntegrationStoreDirectResponseStoreProductTag.Checks,
                "drains" => CreateIntegrationStoreDirectResponseStoreProductTag.Drains,
                "edge-config" => CreateIntegrationStoreDirectResponseStoreProductTag.EdgeConfig,
                "experimentation" => CreateIntegrationStoreDirectResponseStoreProductTag.Experimentation,
                "kv" => CreateIntegrationStoreDirectResponseStoreProductTag.Kv,
                "libsql" => CreateIntegrationStoreDirectResponseStoreProductTag.Libsql,
                "logDrain" => CreateIntegrationStoreDirectResponseStoreProductTag.LogDrain,
                "mcp" => CreateIntegrationStoreDirectResponseStoreProductTag.Mcp,
                "messaging" => CreateIntegrationStoreDirectResponseStoreProductTag.Messaging,
                "mysql" => CreateIntegrationStoreDirectResponseStoreProductTag.Mysql,
                "observability" => CreateIntegrationStoreDirectResponseStoreProductTag.Observability,
                "other" => CreateIntegrationStoreDirectResponseStoreProductTag.Other,
                "postgres" => CreateIntegrationStoreDirectResponseStoreProductTag.Postgres,
                "rds" => CreateIntegrationStoreDirectResponseStoreProductTag.Rds,
                "redis" => CreateIntegrationStoreDirectResponseStoreProductTag.Redis,
                "sqlite" => CreateIntegrationStoreDirectResponseStoreProductTag.Sqlite,
                "storage" => CreateIntegrationStoreDirectResponseStoreProductTag.Storage,
                "tag_agents" => CreateIntegrationStoreDirectResponseStoreProductTag.TagAgents,
                "tag_ai" => CreateIntegrationStoreDirectResponseStoreProductTag.TagAi,
                "tag_analytics" => CreateIntegrationStoreDirectResponseStoreProductTag.TagAnalytics,
                "tag_authentication" => CreateIntegrationStoreDirectResponseStoreProductTag.TagAuthentication,
                "tag_checks" => CreateIntegrationStoreDirectResponseStoreProductTag.TagChecks,
                "tag_cms" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCms,
                "tag_code_repository" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeRepository,
                "tag_code_review" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeReview,
                "tag_code_security" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeSecurity,
                "tag_code_testing" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCodeTesting,
                "tag_commerce" => CreateIntegrationStoreDirectResponseStoreProductTag.TagCommerce,
                "tag_databases" => CreateIntegrationStoreDirectResponseStoreProductTag.TagDatabases,
                "tag_dev_tools" => CreateIntegrationStoreDirectResponseStoreProductTag.TagDevTools,
                "tag_experimentation" => CreateIntegrationStoreDirectResponseStoreProductTag.TagExperimentation,
                "tag_flags" => CreateIntegrationStoreDirectResponseStoreProductTag.TagFlags,
                "tag_logDrain" => CreateIntegrationStoreDirectResponseStoreProductTag.TagLogDrain,
                "tag_logging" => CreateIntegrationStoreDirectResponseStoreProductTag.TagLogging,
                "tag_messaging" => CreateIntegrationStoreDirectResponseStoreProductTag.TagMessaging,
                "tag_monitoring" => CreateIntegrationStoreDirectResponseStoreProductTag.TagMonitoring,
                "tag_observability" => CreateIntegrationStoreDirectResponseStoreProductTag.TagObservability,
                "tag_other" => CreateIntegrationStoreDirectResponseStoreProductTag.TagOther,
                "tag_payments" => CreateIntegrationStoreDirectResponseStoreProductTag.TagPayments,
                "tag_performance" => CreateIntegrationStoreDirectResponseStoreProductTag.TagPerformance,
                "tag_productivity" => CreateIntegrationStoreDirectResponseStoreProductTag.TagProductivity,
                "tag_searching" => CreateIntegrationStoreDirectResponseStoreProductTag.TagSearching,
                "tag_security" => CreateIntegrationStoreDirectResponseStoreProductTag.TagSecurity,
                "tag_storage" => CreateIntegrationStoreDirectResponseStoreProductTag.TagStorage,
                "tag_support_agent" => CreateIntegrationStoreDirectResponseStoreProductTag.TagSupportAgent,
                "tag_testing" => CreateIntegrationStoreDirectResponseStoreProductTag.TagTesting,
                "tag_traceDrain" => CreateIntegrationStoreDirectResponseStoreProductTag.TagTraceDrain,
                "tag_video" => CreateIntegrationStoreDirectResponseStoreProductTag.TagVideo,
                "tag_web_automation" => CreateIntegrationStoreDirectResponseStoreProductTag.TagWebAutomation,
                "tag_workflow" => CreateIntegrationStoreDirectResponseStoreProductTag.TagWorkflow,
                "traceDrain" => CreateIntegrationStoreDirectResponseStoreProductTag.TraceDrain,
                "vector" => CreateIntegrationStoreDirectResponseStoreProductTag.Vector,
                "video" => CreateIntegrationStoreDirectResponseStoreProductTag.Video,
                "workflow" => CreateIntegrationStoreDirectResponseStoreProductTag.Workflow,
                _ => null,
            };
        }
    }
}