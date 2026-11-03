
#nullable enable

namespace Vercel
{
    /// <summary>
    /// - team: `https://oidc.vercel.com/[team_slug]` - global: `https://oidc.vercel.com`
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode
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
    public static class AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode.Global => "global",
                AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode? ToEnum(string value)
        {
            return value switch
            {
                "global" => AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode.Global,
                "team" => AutoSDKSharedbfe68caea048321bOidcTokenConfigIssuerMode.Team,
                _ => null,
            };
        }
    }
}