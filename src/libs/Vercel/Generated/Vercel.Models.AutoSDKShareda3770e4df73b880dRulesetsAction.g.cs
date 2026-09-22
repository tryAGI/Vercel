
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dRulesetsAction
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
    public static class AutoSDKShareda3770e4df73b880dRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dRulesetsAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dRulesetsAction.Allow => "allow",
                AutoSDKShareda3770e4df73b880dRulesetsAction.Bypass => "bypass",
                AutoSDKShareda3770e4df73b880dRulesetsAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dRulesetsAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dRulesetsAction.Log => "log",
                AutoSDKShareda3770e4df73b880dRulesetsAction.RateLimit => "rate_limit",
                AutoSDKShareda3770e4df73b880dRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShareda3770e4df73b880dRulesetsAction.Allow,
                "bypass" => AutoSDKShareda3770e4df73b880dRulesetsAction.Bypass,
                "challenge" => AutoSDKShareda3770e4df73b880dRulesetsAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dRulesetsAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dRulesetsAction.Log,
                "rate_limit" => AutoSDKShareda3770e4df73b880dRulesetsAction.RateLimit,
                "redirect" => AutoSDKShareda3770e4df73b880dRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}