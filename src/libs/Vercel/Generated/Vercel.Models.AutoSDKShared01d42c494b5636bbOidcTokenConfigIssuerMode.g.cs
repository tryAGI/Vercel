
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode
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
    public static class AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKShared01d42c494b5636bbOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}