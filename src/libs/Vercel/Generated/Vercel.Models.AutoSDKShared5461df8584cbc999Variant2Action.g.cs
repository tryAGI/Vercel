
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5461df8584cbc999Variant2Action
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
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
    public static class AutoSDKShared5461df8584cbc999Variant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5461df8584cbc999Variant2Action value)
        {
            return value switch
            {
                AutoSDKShared5461df8584cbc999Variant2Action.Allow => "allow",
                AutoSDKShared5461df8584cbc999Variant2Action.Bypass => "bypass",
                AutoSDKShared5461df8584cbc999Variant2Action.Challenge => "challenge",
                AutoSDKShared5461df8584cbc999Variant2Action.Deny => "deny",
                AutoSDKShared5461df8584cbc999Variant2Action.Log => "log",
                AutoSDKShared5461df8584cbc999Variant2Action.RateLimit => "rate_limit",
                AutoSDKShared5461df8584cbc999Variant2Action.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5461df8584cbc999Variant2Action? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared5461df8584cbc999Variant2Action.Allow,
                "bypass" => AutoSDKShared5461df8584cbc999Variant2Action.Bypass,
                "challenge" => AutoSDKShared5461df8584cbc999Variant2Action.Challenge,
                "deny" => AutoSDKShared5461df8584cbc999Variant2Action.Deny,
                "log" => AutoSDKShared5461df8584cbc999Variant2Action.Log,
                "rate_limit" => AutoSDKShared5461df8584cbc999Variant2Action.RateLimit,
                "redirect" => AutoSDKShared5461df8584cbc999Variant2Action.Redirect,
                _ => null,
            };
        }
    }
}