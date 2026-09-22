
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3770e4df73b880dManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}