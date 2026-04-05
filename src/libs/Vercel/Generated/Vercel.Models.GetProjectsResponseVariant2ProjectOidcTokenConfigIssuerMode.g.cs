
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode
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
    public static class GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode.Global => "global",
                GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode.Global,
                "team" => GetProjectsResponseVariant2ProjectOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}