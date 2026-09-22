
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3cefeabeb1d55c64Variant2Action
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
    public static class AutoSDKShared3cefeabeb1d55c64Variant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3cefeabeb1d55c64Variant2Action value)
        {
            return value switch
            {
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Allow => "allow",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Bypass => "bypass",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Challenge => "challenge",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Deny => "deny",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Log => "log",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.RateLimit => "rate_limit",
                AutoSDKShared3cefeabeb1d55c64Variant2Action.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3cefeabeb1d55c64Variant2Action? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Allow,
                "bypass" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Bypass,
                "challenge" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Challenge,
                "deny" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Deny,
                "log" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Log,
                "rate_limit" => AutoSDKShared3cefeabeb1d55c64Variant2Action.RateLimit,
                "redirect" => AutoSDKShared3cefeabeb1d55c64Variant2Action.Redirect,
                _ => null,
            };
        }
    }
}