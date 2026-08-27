
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RotateInstallationCredentialResponseTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Oauth2Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateInstallationCredentialResponseTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateInstallationCredentialResponseTokenType value)
        {
            return value switch
            {
                RotateInstallationCredentialResponseTokenType.Oauth2Token => "oauth2-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateInstallationCredentialResponseTokenType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2-token" => RotateInstallationCredentialResponseTokenType.Oauth2Token,
                _ => null,
            };
        }
    }
}