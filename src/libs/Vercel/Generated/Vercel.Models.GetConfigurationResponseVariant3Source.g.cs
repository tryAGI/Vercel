
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
    /// Example: marketplace
    /// </summary>
    public enum GetConfigurationResponseVariant3Source
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
    public static class GetConfigurationResponseVariant3SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant3Source value)
        {
            return value switch
            {
                GetConfigurationResponseVariant3Source.Backoffice => "backoffice",
                GetConfigurationResponseVariant3Source.Cli => "cli",
                GetConfigurationResponseVariant3Source.DeployButton => "deploy-button",
                GetConfigurationResponseVariant3Source.External => "external",
                GetConfigurationResponseVariant3Source.Marketplace => "marketplace",
                GetConfigurationResponseVariant3Source.Oauth => "oauth",
                GetConfigurationResponseVariant3Source.ResourceClaims => "resource-claims",
                GetConfigurationResponseVariant3Source.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant3Source? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetConfigurationResponseVariant3Source.Backoffice,
                "cli" => GetConfigurationResponseVariant3Source.Cli,
                "deploy-button" => GetConfigurationResponseVariant3Source.DeployButton,
                "external" => GetConfigurationResponseVariant3Source.External,
                "marketplace" => GetConfigurationResponseVariant3Source.Marketplace,
                "oauth" => GetConfigurationResponseVariant3Source.Oauth,
                "resource-claims" => GetConfigurationResponseVariant3Source.ResourceClaims,
                "v0" => GetConfigurationResponseVariant3Source.V0,
                _ => null,
            };
        }
    }
}