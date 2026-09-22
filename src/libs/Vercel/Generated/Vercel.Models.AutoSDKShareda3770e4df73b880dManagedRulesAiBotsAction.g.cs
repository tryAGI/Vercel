
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction
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
    public static class AutoSDKShareda3770e4df73b880dManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Challenge => "challenge",
                AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Deny => "deny",
                AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Challenge,
                "deny" => AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Deny,
                "log" => AutoSDKShareda3770e4df73b880dManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}