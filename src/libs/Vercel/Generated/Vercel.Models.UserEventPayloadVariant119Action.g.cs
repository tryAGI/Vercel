
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant119Action
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
    public static class UserEventPayloadVariant119ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant119Action value)
        {
            return value switch
            {
                UserEventPayloadVariant119Action.Challenge => "challenge",
                UserEventPayloadVariant119Action.Deny => "deny",
                UserEventPayloadVariant119Action.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant119Action? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant119Action.Challenge,
                "deny" => UserEventPayloadVariant119Action.Deny,
                "log" => UserEventPayloadVariant119Action.Log,
                _ => null,
            };
        }
    }
}