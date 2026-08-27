
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType
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
    public static class UploadProjectAvatarResponseTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.All => "all",
                UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.Preview => "preview",
                UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UploadProjectAvatarResponseTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}