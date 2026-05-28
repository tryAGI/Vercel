
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target
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
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview => "preview",
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview,
                "production" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}