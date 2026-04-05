
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
    /// Example: marketplace
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Backoffice,
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        DeployButton,
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Marketplace,
        /// <summary>
        /// 
        /// </summary>
        Oauth,
        /// <summary>
        /// 
        /// </summary>
        ResourceClaims,
        /// <summary>
        /// 
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsResponseVariant2ItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemSource value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemSource.Backoffice => "backoffice",
                GetConfigurationsResponseVariant2ItemSource.Cli => "cli",
                GetConfigurationsResponseVariant2ItemSource.DeployButton => "deploy-button",
                GetConfigurationsResponseVariant2ItemSource.External => "external",
                GetConfigurationsResponseVariant2ItemSource.Marketplace => "marketplace",
                GetConfigurationsResponseVariant2ItemSource.Oauth => "oauth",
                GetConfigurationsResponseVariant2ItemSource.ResourceClaims => "resource-claims",
                GetConfigurationsResponseVariant2ItemSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemSource? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetConfigurationsResponseVariant2ItemSource.Backoffice,
                "cli" => GetConfigurationsResponseVariant2ItemSource.Cli,
                "deploy-button" => GetConfigurationsResponseVariant2ItemSource.DeployButton,
                "external" => GetConfigurationsResponseVariant2ItemSource.External,
                "marketplace" => GetConfigurationsResponseVariant2ItemSource.Marketplace,
                "oauth" => GetConfigurationsResponseVariant2ItemSource.Oauth,
                "resource-claims" => GetConfigurationsResponseVariant2ItemSource.ResourceClaims,
                "v0" => GetConfigurationsResponseVariant2ItemSource.V0,
                _ => null,
            };
        }
    }
}