
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedfe1f84289679c6c4OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}