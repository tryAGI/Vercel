
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Categories that group this event type with related event types.<br/>
    /// Example: [deployment]
    /// </summary>
    public enum ListEventTypeCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        Account,
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        AiGateway,
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Connect,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        Domain,
        /// <summary>
        /// 
        /// </summary>
        Edge,
        /// <summary>
        /// 
        /// </summary>
        EnvVariable,
        /// <summary>
        /// 
        /// </summary>
        FeatureFlags,
        /// <summary>
        /// 
        /// </summary>
        Firewall,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        Microfrontends,
        /// <summary>
        /// 
        /// </summary>
        Network,
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
        Project,
        /// <summary>
        /// 
        /// </summary>
        Security,
        /// <summary>
        /// 
        /// </summary>
        Storage,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        V0,
        /// <summary>
        /// 
        /// </summary>
        VercelApp,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEventTypeCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEventTypeCategorie value)
        {
            return value switch
            {
                ListEventTypeCategorie.Account => "account",
                ListEventTypeCategorie.Ai => "ai",
                ListEventTypeCategorie.AiGateway => "ai-gateway",
                ListEventTypeCategorie.Billing => "billing",
                ListEventTypeCategorie.Connect => "connect",
                ListEventTypeCategorie.Deployment => "deployment",
                ListEventTypeCategorie.Domain => "domain",
                ListEventTypeCategorie.Edge => "edge",
                ListEventTypeCategorie.EnvVariable => "env-variable",
                ListEventTypeCategorie.FeatureFlags => "feature-flags",
                ListEventTypeCategorie.Firewall => "firewall",
                ListEventTypeCategorie.Integration => "integration",
                ListEventTypeCategorie.Microfrontends => "microfrontends",
                ListEventTypeCategorie.Network => "network",
                ListEventTypeCategorie.Observability => "observability",
                ListEventTypeCategorie.Other => "other",
                ListEventTypeCategorie.Project => "project",
                ListEventTypeCategorie.Security => "security",
                ListEventTypeCategorie.Storage => "storage",
                ListEventTypeCategorie.Team => "team",
                ListEventTypeCategorie.V0 => "v0",
                ListEventTypeCategorie.VercelApp => "vercel-app",
                ListEventTypeCategorie.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEventTypeCategorie? ToEnum(string value)
        {
            return value switch
            {
                "account" => ListEventTypeCategorie.Account,
                "ai" => ListEventTypeCategorie.Ai,
                "ai-gateway" => ListEventTypeCategorie.AiGateway,
                "billing" => ListEventTypeCategorie.Billing,
                "connect" => ListEventTypeCategorie.Connect,
                "deployment" => ListEventTypeCategorie.Deployment,
                "domain" => ListEventTypeCategorie.Domain,
                "edge" => ListEventTypeCategorie.Edge,
                "env-variable" => ListEventTypeCategorie.EnvVariable,
                "feature-flags" => ListEventTypeCategorie.FeatureFlags,
                "firewall" => ListEventTypeCategorie.Firewall,
                "integration" => ListEventTypeCategorie.Integration,
                "microfrontends" => ListEventTypeCategorie.Microfrontends,
                "network" => ListEventTypeCategorie.Network,
                "observability" => ListEventTypeCategorie.Observability,
                "other" => ListEventTypeCategorie.Other,
                "project" => ListEventTypeCategorie.Project,
                "security" => ListEventTypeCategorie.Security,
                "storage" => ListEventTypeCategorie.Storage,
                "team" => ListEventTypeCategorie.Team,
                "v0" => ListEventTypeCategorie.V0,
                "vercel-app" => ListEventTypeCategorie.VercelApp,
                "workflow" => ListEventTypeCategorie.Workflow,
                _ => null,
            };
        }
    }
}