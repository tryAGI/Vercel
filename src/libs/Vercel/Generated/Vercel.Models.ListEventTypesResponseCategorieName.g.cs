
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEventTypesResponseCategorieName
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
    public static class ListEventTypesResponseCategorieNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEventTypesResponseCategorieName value)
        {
            return value switch
            {
                ListEventTypesResponseCategorieName.Account => "account",
                ListEventTypesResponseCategorieName.Ai => "ai",
                ListEventTypesResponseCategorieName.AiGateway => "ai-gateway",
                ListEventTypesResponseCategorieName.Billing => "billing",
                ListEventTypesResponseCategorieName.Connect => "connect",
                ListEventTypesResponseCategorieName.Deployment => "deployment",
                ListEventTypesResponseCategorieName.Domain => "domain",
                ListEventTypesResponseCategorieName.Edge => "edge",
                ListEventTypesResponseCategorieName.EnvVariable => "env-variable",
                ListEventTypesResponseCategorieName.FeatureFlags => "feature-flags",
                ListEventTypesResponseCategorieName.Firewall => "firewall",
                ListEventTypesResponseCategorieName.Integration => "integration",
                ListEventTypesResponseCategorieName.Microfrontends => "microfrontends",
                ListEventTypesResponseCategorieName.Network => "network",
                ListEventTypesResponseCategorieName.Observability => "observability",
                ListEventTypesResponseCategorieName.Other => "other",
                ListEventTypesResponseCategorieName.Project => "project",
                ListEventTypesResponseCategorieName.Security => "security",
                ListEventTypesResponseCategorieName.Storage => "storage",
                ListEventTypesResponseCategorieName.Team => "team",
                ListEventTypesResponseCategorieName.V0 => "v0",
                ListEventTypesResponseCategorieName.VercelApp => "vercel-app",
                ListEventTypesResponseCategorieName.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEventTypesResponseCategorieName? ToEnum(string value)
        {
            return value switch
            {
                "account" => ListEventTypesResponseCategorieName.Account,
                "ai" => ListEventTypesResponseCategorieName.Ai,
                "ai-gateway" => ListEventTypesResponseCategorieName.AiGateway,
                "billing" => ListEventTypesResponseCategorieName.Billing,
                "connect" => ListEventTypesResponseCategorieName.Connect,
                "deployment" => ListEventTypesResponseCategorieName.Deployment,
                "domain" => ListEventTypesResponseCategorieName.Domain,
                "edge" => ListEventTypesResponseCategorieName.Edge,
                "env-variable" => ListEventTypesResponseCategorieName.EnvVariable,
                "feature-flags" => ListEventTypesResponseCategorieName.FeatureFlags,
                "firewall" => ListEventTypesResponseCategorieName.Firewall,
                "integration" => ListEventTypesResponseCategorieName.Integration,
                "microfrontends" => ListEventTypesResponseCategorieName.Microfrontends,
                "network" => ListEventTypesResponseCategorieName.Network,
                "observability" => ListEventTypesResponseCategorieName.Observability,
                "other" => ListEventTypesResponseCategorieName.Other,
                "project" => ListEventTypesResponseCategorieName.Project,
                "security" => ListEventTypesResponseCategorieName.Security,
                "storage" => ListEventTypesResponseCategorieName.Storage,
                "team" => ListEventTypesResponseCategorieName.Team,
                "v0" => ListEventTypesResponseCategorieName.V0,
                "vercel-app" => ListEventTypesResponseCategorieName.VercelApp,
                "workflow" => ListEventTypesResponseCategorieName.Workflow,
                _ => null,
            };
        }
    }
}