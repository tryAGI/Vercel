
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum GetProjectResponseOidcTokenConfigIssuerMode
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
    public static class GetProjectResponseOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                GetProjectResponseOidcTokenConfigIssuerMode.Global => "global",
                GetProjectResponseOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => GetProjectResponseOidcTokenConfigIssuerMode.Global,
                "team" => GetProjectResponseOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}