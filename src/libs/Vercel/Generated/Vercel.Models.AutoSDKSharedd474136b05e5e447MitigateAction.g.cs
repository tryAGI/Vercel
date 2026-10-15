
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447MitigateAction
    {
        /// <summary>
        ///
        /// </summary>
        Bypass,
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
        /// <summary>
        ///
        /// </summary>
        RateLimit,
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447MitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447MitigateAction.Bypass => "bypass",
                AutoSDKSharedd474136b05e5e447MitigateAction.Challenge => "challenge",
                AutoSDKSharedd474136b05e5e447MitigateAction.Deny => "deny",
                AutoSDKSharedd474136b05e5e447MitigateAction.Log => "log",
                AutoSDKSharedd474136b05e5e447MitigateAction.RateLimit => "rate_limit",
                AutoSDKSharedd474136b05e5e447MitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKSharedd474136b05e5e447MitigateAction.Bypass,
                "challenge" => AutoSDKSharedd474136b05e5e447MitigateAction.Challenge,
                "deny" => AutoSDKSharedd474136b05e5e447MitigateAction.Deny,
                "log" => AutoSDKSharedd474136b05e5e447MitigateAction.Log,
                "rate_limit" => AutoSDKSharedd474136b05e5e447MitigateAction.RateLimit,
                "redirect" => AutoSDKSharedd474136b05e5e447MitigateAction.Redirect,
                _ => null,
            };
        }
    }
}