
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant112Action
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
    public static class UserEventPayloadVariant112ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant112Action value)
        {
            return value switch
            {
                UserEventPayloadVariant112Action.Challenge => "challenge",
                UserEventPayloadVariant112Action.Deny => "deny",
                UserEventPayloadVariant112Action.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant112Action? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant112Action.Challenge,
                "deny" => UserEventPayloadVariant112Action.Deny,
                "log" => UserEventPayloadVariant112Action.Log,
                _ => null,
            };
        }
    }
}