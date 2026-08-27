
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        AllExceptCustomDomains,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        ProdDeploymentUrlsAndAllPreviews,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.All => "all",
                UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.Preview => "preview",
                UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UploadProjectAvatarResponseTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}