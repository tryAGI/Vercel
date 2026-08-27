
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}