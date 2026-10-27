
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedc9c79e81839bbccdOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}