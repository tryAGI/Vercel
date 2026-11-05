
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode
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
    public static class AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared6da23cf13a2bd202OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}