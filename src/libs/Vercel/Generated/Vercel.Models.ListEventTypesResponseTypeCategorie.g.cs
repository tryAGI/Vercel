
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEventTypesResponseTypeCategorie
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
    public static class ListEventTypesResponseTypeCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEventTypesResponseTypeCategorie value)
        {
            return value switch
            {
                ListEventTypesResponseTypeCategorie.Account => "account",
                ListEventTypesResponseTypeCategorie.Ai => "ai",
                ListEventTypesResponseTypeCategorie.AiGateway => "ai-gateway",
                ListEventTypesResponseTypeCategorie.Billing => "billing",
                ListEventTypesResponseTypeCategorie.Deployment => "deployment",
                ListEventTypesResponseTypeCategorie.Domain => "domain",
                ListEventTypesResponseTypeCategorie.Edge => "edge",
                ListEventTypesResponseTypeCategorie.EnvVariable => "env-variable",
                ListEventTypesResponseTypeCategorie.FeatureFlags => "feature-flags",
                ListEventTypesResponseTypeCategorie.Firewall => "firewall",
                ListEventTypesResponseTypeCategorie.Integration => "integration",
                ListEventTypesResponseTypeCategorie.Microfrontends => "microfrontends",
                ListEventTypesResponseTypeCategorie.Network => "network",
                ListEventTypesResponseTypeCategorie.Observability => "observability",
                ListEventTypesResponseTypeCategorie.Other => "other",
                ListEventTypesResponseTypeCategorie.Project => "project",
                ListEventTypesResponseTypeCategorie.Security => "security",
                ListEventTypesResponseTypeCategorie.Storage => "storage",
                ListEventTypesResponseTypeCategorie.Team => "team",
                ListEventTypesResponseTypeCategorie.V0 => "v0",
                ListEventTypesResponseTypeCategorie.VercelApp => "vercel-app",
                ListEventTypesResponseTypeCategorie.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEventTypesResponseTypeCategorie? ToEnum(string value)
        {
            return value switch
            {
                "account" => ListEventTypesResponseTypeCategorie.Account,
                "ai" => ListEventTypesResponseTypeCategorie.Ai,
                "ai-gateway" => ListEventTypesResponseTypeCategorie.AiGateway,
                "billing" => ListEventTypesResponseTypeCategorie.Billing,
                "deployment" => ListEventTypesResponseTypeCategorie.Deployment,
                "domain" => ListEventTypesResponseTypeCategorie.Domain,
                "edge" => ListEventTypesResponseTypeCategorie.Edge,
                "env-variable" => ListEventTypesResponseTypeCategorie.EnvVariable,
                "feature-flags" => ListEventTypesResponseTypeCategorie.FeatureFlags,
                "firewall" => ListEventTypesResponseTypeCategorie.Firewall,
                "integration" => ListEventTypesResponseTypeCategorie.Integration,
                "microfrontends" => ListEventTypesResponseTypeCategorie.Microfrontends,
                "network" => ListEventTypesResponseTypeCategorie.Network,
                "observability" => ListEventTypesResponseTypeCategorie.Observability,
                "other" => ListEventTypesResponseTypeCategorie.Other,
                "project" => ListEventTypesResponseTypeCategorie.Project,
                "security" => ListEventTypesResponseTypeCategorie.Security,
                "storage" => ListEventTypesResponseTypeCategorie.Storage,
                "team" => ListEventTypesResponseTypeCategorie.Team,
                "v0" => ListEventTypesResponseTypeCategorie.V0,
                "vercel-app" => ListEventTypesResponseTypeCategorie.VercelApp,
                "workflow" => ListEventTypesResponseTypeCategorie.Workflow,
                _ => null,
            };
        }
    }
}