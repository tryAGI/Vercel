
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The categories that group this event with related event types. An event can belong to multiple categories (e.g. a firewall event is both Firewall and Security). The first entry is the "primary" category. Use the `/events/types` endpoint to discover the full list of categories.<br/>
    /// Example: [deployment]
    /// </summary>
    public enum UserEventCategorie
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
    public static class UserEventCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventCategorie value)
        {
            return value switch
            {
                UserEventCategorie.Account => "account",
                UserEventCategorie.Ai => "ai",
                UserEventCategorie.AiGateway => "ai-gateway",
                UserEventCategorie.Billing => "billing",
                UserEventCategorie.Deployment => "deployment",
                UserEventCategorie.Domain => "domain",
                UserEventCategorie.Edge => "edge",
                UserEventCategorie.EnvVariable => "env-variable",
                UserEventCategorie.FeatureFlags => "feature-flags",
                UserEventCategorie.Firewall => "firewall",
                UserEventCategorie.Integration => "integration",
                UserEventCategorie.Microfrontends => "microfrontends",
                UserEventCategorie.Network => "network",
                UserEventCategorie.Observability => "observability",
                UserEventCategorie.Other => "other",
                UserEventCategorie.Project => "project",
                UserEventCategorie.Security => "security",
                UserEventCategorie.Storage => "storage",
                UserEventCategorie.Team => "team",
                UserEventCategorie.V0 => "v0",
                UserEventCategorie.VercelApp => "vercel-app",
                UserEventCategorie.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventCategorie? ToEnum(string value)
        {
            return value switch
            {
                "account" => UserEventCategorie.Account,
                "ai" => UserEventCategorie.Ai,
                "ai-gateway" => UserEventCategorie.AiGateway,
                "billing" => UserEventCategorie.Billing,
                "deployment" => UserEventCategorie.Deployment,
                "domain" => UserEventCategorie.Domain,
                "edge" => UserEventCategorie.Edge,
                "env-variable" => UserEventCategorie.EnvVariable,
                "feature-flags" => UserEventCategorie.FeatureFlags,
                "firewall" => UserEventCategorie.Firewall,
                "integration" => UserEventCategorie.Integration,
                "microfrontends" => UserEventCategorie.Microfrontends,
                "network" => UserEventCategorie.Network,
                "observability" => UserEventCategorie.Observability,
                "other" => UserEventCategorie.Other,
                "project" => UserEventCategorie.Project,
                "security" => UserEventCategorie.Security,
                "storage" => UserEventCategorie.Storage,
                "team" => UserEventCategorie.Team,
                "v0" => UserEventCategorie.V0,
                "vercel-app" => UserEventCategorie.VercelApp,
                "workflow" => UserEventCategorie.Workflow,
                _ => null,
            };
        }
    }
}