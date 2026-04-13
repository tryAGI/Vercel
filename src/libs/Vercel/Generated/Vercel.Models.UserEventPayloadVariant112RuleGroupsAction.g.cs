
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant112RuleGroupsAction
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
    public static class UserEventPayloadVariant112RuleGroupsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant112RuleGroupsAction value)
        {
            return value switch
            {
                UserEventPayloadVariant112RuleGroupsAction.Challenge => "challenge",
                UserEventPayloadVariant112RuleGroupsAction.Deny => "deny",
                UserEventPayloadVariant112RuleGroupsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant112RuleGroupsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant112RuleGroupsAction.Challenge,
                "deny" => UserEventPayloadVariant112RuleGroupsAction.Deny,
                "log" => UserEventPayloadVariant112RuleGroupsAction.Log,
                _ => null,
            };
        }
    }
}