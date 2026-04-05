
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode
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
    public static class UpdateMicrofrontendsResponseOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode.Global => "global",
                UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode.Global,
                "team" => UpdateMicrofrontendsResponseOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}