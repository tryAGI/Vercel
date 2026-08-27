
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseConnectConfigurationEnvId
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
    public static class UploadProjectAvatarResponseConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseConnectConfigurationEnvId value)
        {
            return value switch
            {
                UploadProjectAvatarResponseConnectConfigurationEnvId.Preview => "preview",
                UploadProjectAvatarResponseConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UploadProjectAvatarResponseConnectConfigurationEnvId.Preview,
                "production" => UploadProjectAvatarResponseConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}