
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponsePassportDeploymentType
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
    public static class UploadProjectAvatarResponsePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponsePassportDeploymentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponsePassportDeploymentType.All => "all",
                UploadProjectAvatarResponsePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UploadProjectAvatarResponsePassportDeploymentType.Preview => "preview",
                UploadProjectAvatarResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponsePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UploadProjectAvatarResponsePassportDeploymentType.All,
                "all_except_custom_domains" => UploadProjectAvatarResponsePassportDeploymentType.AllExceptCustomDomains,
                "preview" => UploadProjectAvatarResponsePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UploadProjectAvatarResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}