
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedba7c6b12ca723bfbOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}