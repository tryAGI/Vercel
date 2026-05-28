
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}