
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum CreateProjectResponseOidcTokenConfigIssuerMode
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
    public static class CreateProjectResponseOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                CreateProjectResponseOidcTokenConfigIssuerMode.Global => "global",
                CreateProjectResponseOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => CreateProjectResponseOidcTokenConfigIssuerMode.Global,
                "team" => CreateProjectResponseOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}