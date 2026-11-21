
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedcdc721d768aa23c0OidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}