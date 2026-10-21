
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode
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
    public static class AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared0d52d5fc16437df8OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}