
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBillingPlansSource
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
    public static class GetBillingPlansSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingPlansSource value)
        {
            return value switch
            {
                GetBillingPlansSource.Backoffice => "backoffice",
                GetBillingPlansSource.Cli => "cli",
                GetBillingPlansSource.DeployButton => "deploy-button",
                GetBillingPlansSource.External => "external",
                GetBillingPlansSource.Marketplace => "marketplace",
                GetBillingPlansSource.Oauth => "oauth",
                GetBillingPlansSource.ResourceClaims => "resource-claims",
                GetBillingPlansSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingPlansSource? ToEnum(string value)
        {
            return value switch
            {
                "backoffice" => GetBillingPlansSource.Backoffice,
                "cli" => GetBillingPlansSource.Cli,
                "deploy-button" => GetBillingPlansSource.DeployButton,
                "external" => GetBillingPlansSource.External,
                "marketplace" => GetBillingPlansSource.Marketplace,
                "oauth" => GetBillingPlansSource.Oauth,
                "resource-claims" => GetBillingPlansSource.ResourceClaims,
                "v0" => GetBillingPlansSource.V0,
                _ => null,
            };
        }
    }
}