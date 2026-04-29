
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant118RuleGroupsAction
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
    public static class UserEventPayloadVariant118RuleGroupsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant118RuleGroupsAction value)
        {
            return value switch
            {
                UserEventPayloadVariant118RuleGroupsAction.Challenge => "challenge",
                UserEventPayloadVariant118RuleGroupsAction.Deny => "deny",
                UserEventPayloadVariant118RuleGroupsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant118RuleGroupsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant118RuleGroupsAction.Challenge,
                "deny" => UserEventPayloadVariant118RuleGroupsAction.Deny,
                "log" => UserEventPayloadVariant118RuleGroupsAction.Log,
                _ => null,
            };
        }
    }
}