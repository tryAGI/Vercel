
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
    /// Example: marketplace
    /// </summary>
    public enum GetConfigurationResponseVariant1Source
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
    public static class GetConfigurationResponseVariant1SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1Source value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1Source.Backoffice => "backoffice",
                GetConfigurationResponseVariant1Source.Cli => "cli",
                GetConfigurationResponseVariant1Source.DeployButton => "deploy-button",
                GetConfigurationResponseVariant1Source.External => "external",
                GetConfigurationResponseVariant1Source.Marketplace => "marketplace",
                GetConfigurationResponseVariant1Source.Oauth => "oauth",
                GetConfigurationResponseVariant1Source.ResourceClaims => "resource-claims",
                GetConfigurationResponseVariant1Source.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1Source? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetConfigurationResponseVariant1Source.Backoffice,
                "cli" => GetConfigurationResponseVariant1Source.Cli,
                "deploy-button" => GetConfigurationResponseVariant1Source.DeployButton,
                "external" => GetConfigurationResponseVariant1Source.External,
                "marketplace" => GetConfigurationResponseVariant1Source.Marketplace,
                "oauth" => GetConfigurationResponseVariant1Source.Oauth,
                "resource-claims" => GetConfigurationResponseVariant1Source.ResourceClaims,
                "v0" => GetConfigurationResponseVariant1Source.V0,
                _ => null,
            };
        }
    }
}