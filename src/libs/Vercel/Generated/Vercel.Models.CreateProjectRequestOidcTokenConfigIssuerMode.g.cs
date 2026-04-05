
#nullable enable

namespace Vercel
{
    /// <summary>
    /// team: `https://oidc.vercel.com/[team_slug]` global: `https://oidc.vercel.com`<br/>
    /// Default Value: team
    /// </summary>
    public enum CreateProjectRequestOidcTokenConfigIssuerMode
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
    public static class CreateProjectRequestOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                CreateProjectRequestOidcTokenConfigIssuerMode.Global => "global",
                CreateProjectRequestOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => CreateProjectRequestOidcTokenConfigIssuerMode.Global,
                "team" => CreateProjectRequestOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}