
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedfc5823c22a1eaa2bOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}