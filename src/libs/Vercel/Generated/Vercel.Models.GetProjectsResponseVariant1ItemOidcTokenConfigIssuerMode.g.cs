
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode
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
    public static class GetProjectsResponseVariant1ItemOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode.Global => "global",
                GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode.Global,
                "team" => GetProjectsResponseVariant1ItemOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}