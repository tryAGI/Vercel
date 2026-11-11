
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedc1c2f92d02e0feb6OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}