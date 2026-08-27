
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseSsoProtectionDeploymentType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSsoProtectionDeploymentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSsoProtectionDeploymentType.All => "all",
                UploadProjectAvatarResponseSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UploadProjectAvatarResponseSsoProtectionDeploymentType.Preview => "preview",
                UploadProjectAvatarResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UploadProjectAvatarResponseSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => UploadProjectAvatarResponseSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UploadProjectAvatarResponseSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UploadProjectAvatarResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}