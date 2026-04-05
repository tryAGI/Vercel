
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
    /// Example: marketplace
    /// </summary>
    public enum GetConfigurationResponseVariant2Source
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
    public static class GetConfigurationResponseVariant2SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant2Source value)
        {
            return value switch
            {
                GetConfigurationResponseVariant2Source.Backoffice => "backoffice",
                GetConfigurationResponseVariant2Source.Cli => "cli",
                GetConfigurationResponseVariant2Source.DeployButton => "deploy-button",
                GetConfigurationResponseVariant2Source.External => "external",
                GetConfigurationResponseVariant2Source.Marketplace => "marketplace",
                GetConfigurationResponseVariant2Source.Oauth => "oauth",
                GetConfigurationResponseVariant2Source.ResourceClaims => "resource-claims",
                GetConfigurationResponseVariant2Source.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant2Source? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetConfigurationResponseVariant2Source.Backoffice,
                "cli" => GetConfigurationResponseVariant2Source.Cli,
                "deploy-button" => GetConfigurationResponseVariant2Source.DeployButton,
                "external" => GetConfigurationResponseVariant2Source.External,
                "marketplace" => GetConfigurationResponseVariant2Source.Marketplace,
                "oauth" => GetConfigurationResponseVariant2Source.Oauth,
                "resource-claims" => GetConfigurationResponseVariant2Source.ResourceClaims,
                "v0" => GetConfigurationResponseVariant2Source.V0,
                _ => null,
            };
        }
    }
}