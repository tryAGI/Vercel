
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode
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
    public static class AutoSDKShared39497871754bda72OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared39497871754bda72OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}