
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview => "preview",
                UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview,
                "production" => UploadProjectAvatarResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}