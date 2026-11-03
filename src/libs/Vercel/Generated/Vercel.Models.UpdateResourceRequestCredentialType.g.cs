
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateResourceRequestCredentialType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResourceRequestCredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResourceRequestCredentialType value)
        {
            return value switch
            {
                UpdateResourceRequestCredentialType.Oidc => "oidc",
                UpdateResourceRequestCredentialType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResourceRequestCredentialType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => UpdateResourceRequestCredentialType.Oidc,
                "static" => UpdateResourceRequestCredentialType.Static,
                _ => null,
            };
        }
    }
}