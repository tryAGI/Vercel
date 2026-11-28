
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode
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
    public static class AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared2eb5520e92a3b839OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}