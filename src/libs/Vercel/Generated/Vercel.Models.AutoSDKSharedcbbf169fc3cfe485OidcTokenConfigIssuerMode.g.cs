
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedcbbf169fc3cfe485OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}