
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode
    {
        /// <summary>
        /// `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
        /// </summary>
        Global,
        /// <summary>
        /// `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedd5e5cf9c62b8ab7fOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}