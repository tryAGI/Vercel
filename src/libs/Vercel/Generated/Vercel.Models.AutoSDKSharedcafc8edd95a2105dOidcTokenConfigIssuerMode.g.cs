
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedcafc8edd95a2105dOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}