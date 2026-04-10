
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant111RuleGroupsAction
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
    public static class UserEventPayloadVariant111RuleGroupsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant111RuleGroupsAction value)
        {
            return value switch
            {
                UserEventPayloadVariant111RuleGroupsAction.Challenge => "challenge",
                UserEventPayloadVariant111RuleGroupsAction.Deny => "deny",
                UserEventPayloadVariant111RuleGroupsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant111RuleGroupsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant111RuleGroupsAction.Challenge,
                "deny" => UserEventPayloadVariant111RuleGroupsAction.Deny,
                "log" => UserEventPayloadVariant111RuleGroupsAction.Log,
                _ => null,
            };
        }
    }
}