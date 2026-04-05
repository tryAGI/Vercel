
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum UpdateProjectResponseOidcTokenConfigIssuerMode
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
    public static class UpdateProjectResponseOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                UpdateProjectResponseOidcTokenConfigIssuerMode.Global => "global",
                UpdateProjectResponseOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateProjectResponseOidcTokenConfigIssuerMode.Global,
                "team" => UpdateProjectResponseOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}