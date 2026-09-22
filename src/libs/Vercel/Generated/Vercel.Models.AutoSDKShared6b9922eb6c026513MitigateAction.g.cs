
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513MitigateAction
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
    public static class AutoSDKShared6b9922eb6c026513MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513MitigateAction value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513MitigateAction.Bypass => "bypass",
                AutoSDKShared6b9922eb6c026513MitigateAction.Challenge => "challenge",
                AutoSDKShared6b9922eb6c026513MitigateAction.Deny => "deny",
                AutoSDKShared6b9922eb6c026513MitigateAction.Log => "log",
                AutoSDKShared6b9922eb6c026513MitigateAction.RateLimit => "rate_limit",
                AutoSDKShared6b9922eb6c026513MitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKShared6b9922eb6c026513MitigateAction.Bypass,
                "challenge" => AutoSDKShared6b9922eb6c026513MitigateAction.Challenge,
                "deny" => AutoSDKShared6b9922eb6c026513MitigateAction.Deny,
                "log" => AutoSDKShared6b9922eb6c026513MitigateAction.Log,
                "rate_limit" => AutoSDKShared6b9922eb6c026513MitigateAction.RateLimit,
                "redirect" => AutoSDKShared6b9922eb6c026513MitigateAction.Redirect,
                _ => null,
            };
        }
    }
}