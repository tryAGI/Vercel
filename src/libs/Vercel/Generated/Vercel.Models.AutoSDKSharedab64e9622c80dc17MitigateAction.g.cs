
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17MitigateAction
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
    public static class AutoSDKSharedab64e9622c80dc17MitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17MitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17MitigateAction.Bypass => "bypass",
                AutoSDKSharedab64e9622c80dc17MitigateAction.Challenge => "challenge",
                AutoSDKSharedab64e9622c80dc17MitigateAction.Deny => "deny",
                AutoSDKSharedab64e9622c80dc17MitigateAction.Log => "log",
                AutoSDKSharedab64e9622c80dc17MitigateAction.RateLimit => "rate_limit",
                AutoSDKSharedab64e9622c80dc17MitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17MitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKSharedab64e9622c80dc17MitigateAction.Bypass,
                "challenge" => AutoSDKSharedab64e9622c80dc17MitigateAction.Challenge,
                "deny" => AutoSDKSharedab64e9622c80dc17MitigateAction.Deny,
                "log" => AutoSDKSharedab64e9622c80dc17MitigateAction.Log,
                "rate_limit" => AutoSDKSharedab64e9622c80dc17MitigateAction.RateLimit,
                "redirect" => AutoSDKSharedab64e9622c80dc17MitigateAction.Redirect,
                _ => null,
            };
        }
    }
}