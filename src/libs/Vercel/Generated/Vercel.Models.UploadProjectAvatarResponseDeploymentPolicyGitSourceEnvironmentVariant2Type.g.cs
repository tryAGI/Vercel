
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}