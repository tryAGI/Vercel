
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode
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
    public static class AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared0b1c50a27c68575dOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}