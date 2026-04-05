
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Source of the store creation request<br/>
    /// Default Value: marketplace<br/>
    /// Example: marketplace
    /// </summary>
    public enum CreateIntegrationStoreDirectRequestSource
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
    public static class CreateIntegrationStoreDirectRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectRequestSource value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectRequestSource.Backoffice => "backoffice",
                CreateIntegrationStoreDirectRequestSource.Cli => "cli",
                CreateIntegrationStoreDirectRequestSource.DeployButton => "deploy-button",
                CreateIntegrationStoreDirectRequestSource.External => "external",
                CreateIntegrationStoreDirectRequestSource.Marketplace => "marketplace",
                CreateIntegrationStoreDirectRequestSource.Oauth => "oauth",
                CreateIntegrationStoreDirectRequestSource.ResourceClaims => "resource-claims",
                CreateIntegrationStoreDirectRequestSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => CreateIntegrationStoreDirectRequestSource.Backoffice,
                "cli" => CreateIntegrationStoreDirectRequestSource.Cli,
                "deploy-button" => CreateIntegrationStoreDirectRequestSource.DeployButton,
                "external" => CreateIntegrationStoreDirectRequestSource.External,
                "marketplace" => CreateIntegrationStoreDirectRequestSource.Marketplace,
                "oauth" => CreateIntegrationStoreDirectRequestSource.Oauth,
                "resource-claims" => CreateIntegrationStoreDirectRequestSource.ResourceClaims,
                "v0" => CreateIntegrationStoreDirectRequestSource.V0,
                _ => null,
            };
        }
    }
}