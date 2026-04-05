
#nullable enable

namespace Vercel
{
    /// <summary>
    /// team: `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`<br/>
    /// Default Value: team
    /// </summary>
    public enum UpdateProjectRequestOidcTokenConfigIssuerMode
    {
        /// <summary>
        /// `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`
        /// </summary>
        Global,
        /// <summary>
        /// `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                UpdateProjectRequestOidcTokenConfigIssuerMode.Global => "global",
                UpdateProjectRequestOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateProjectRequestOidcTokenConfigIssuerMode.Global,
                "team" => UpdateProjectRequestOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}