
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode
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
    public static class GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode.Global => "global",
                GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode.Global,
                "team" => GetProjectsResponseVariant3ProjectOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}