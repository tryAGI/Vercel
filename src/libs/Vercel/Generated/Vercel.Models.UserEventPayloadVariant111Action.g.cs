
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant111Action
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
    public static class UserEventPayloadVariant111ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant111Action value)
        {
            return value switch
            {
                UserEventPayloadVariant111Action.Challenge => "challenge",
                UserEventPayloadVariant111Action.Deny => "deny",
                UserEventPayloadVariant111Action.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant111Action? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant111Action.Challenge,
                "deny" => UserEventPayloadVariant111Action.Deny,
                "log" => UserEventPayloadVariant111Action.Log,
                _ => null,
            };
        }
    }
}