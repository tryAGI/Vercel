
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant113Action
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
    public static class UserEventPayloadVariant113ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113Action value)
        {
            return value switch
            {
                UserEventPayloadVariant113Action.Challenge => "challenge",
                UserEventPayloadVariant113Action.Deny => "deny",
                UserEventPayloadVariant113Action.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113Action? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UserEventPayloadVariant113Action.Challenge,
                "deny" => UserEventPayloadVariant113Action.Deny,
                "log" => UserEventPayloadVariant113Action.Log,
                _ => null,
            };
        }
    }
}