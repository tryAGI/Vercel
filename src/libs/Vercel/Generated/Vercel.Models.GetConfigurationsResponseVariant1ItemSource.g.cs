
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
    /// Example: marketplace
    /// </summary>
    public enum GetConfigurationsResponseVariant1ItemSource
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
    public static class GetConfigurationsResponseVariant1ItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant1ItemSource value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant1ItemSource.Backoffice => "backoffice",
                GetConfigurationsResponseVariant1ItemSource.Cli => "cli",
                GetConfigurationsResponseVariant1ItemSource.DeployButton => "deploy-button",
                GetConfigurationsResponseVariant1ItemSource.External => "external",
                GetConfigurationsResponseVariant1ItemSource.Marketplace => "marketplace",
                GetConfigurationsResponseVariant1ItemSource.Oauth => "oauth",
                GetConfigurationsResponseVariant1ItemSource.ResourceClaims => "resource-claims",
                GetConfigurationsResponseVariant1ItemSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant1ItemSource? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetConfigurationsResponseVariant1ItemSource.Backoffice,
                "cli" => GetConfigurationsResponseVariant1ItemSource.Cli,
                "deploy-button" => GetConfigurationsResponseVariant1ItemSource.DeployButton,
                "external" => GetConfigurationsResponseVariant1ItemSource.External,
                "marketplace" => GetConfigurationsResponseVariant1ItemSource.Marketplace,
                "oauth" => GetConfigurationsResponseVariant1ItemSource.Oauth,
                "resource-claims" => GetConfigurationsResponseVariant1ItemSource.ResourceClaims,
                "v0" => GetConfigurationsResponseVariant1ItemSource.V0,
                _ => null,
            };
        }
    }
}