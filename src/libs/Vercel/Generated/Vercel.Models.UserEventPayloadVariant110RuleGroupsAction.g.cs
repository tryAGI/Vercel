
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant110RuleGroupsAction
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
    public static class UserEventPayloadVariant110RuleGroupsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant110RuleGroupsAction value)
        {
            return value switch
            {
                UserEventPayloadVariant110RuleGroupsAction.Challenge => "challenge",
                UserEventPayloadVariant110RuleGroupsAction.Deny => "deny",
                UserEventPayloadVariant110RuleGroupsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant110RuleGroupsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant110RuleGroupsAction.Challenge,
                "deny" => UserEventPayloadVariant110RuleGroupsAction.Deny,
                "log" => UserEventPayloadVariant110RuleGroupsAction.Log,
                _ => null,
            };
        }
    }
}