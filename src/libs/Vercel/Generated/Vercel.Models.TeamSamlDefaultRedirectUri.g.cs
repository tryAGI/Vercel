
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The default redirect URI to use after successful SAML authentication.
    /// </summary>
    public enum TeamSamlDefaultRedirectUri
    {
        /// <summary>
        /// 
        /// </summary>
        V0App,
        /// <summary>
        /// 
        /// </summary>
        V0Dev,
        /// <summary>
        /// 
        /// </summary>
        VercelCom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamSamlDefaultRedirectUriExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlDefaultRedirectUri value)
        {
            return value switch
            {
                TeamSamlDefaultRedirectUri.V0App => "v0.app",
                TeamSamlDefaultRedirectUri.V0Dev => "v0.dev",
                TeamSamlDefaultRedirectUri.VercelCom => "vercel.com",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlDefaultRedirectUri? ToEnum(string value)
        {
            return value switch
            {
                "v0.app" => TeamSamlDefaultRedirectUri.V0App,
                "v0.dev" => TeamSamlDefaultRedirectUri.V0Dev,
                "vercel.com" => TeamSamlDefaultRedirectUri.VercelCom,
                _ => null,
            };
        }
    }
}