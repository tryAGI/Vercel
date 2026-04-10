
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
        Disable,
        /// <summary>
        /// 
        /// </summary>
        Enable,
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
                UserEventPayloadVariant113Action.Disable => "disable",
                UserEventPayloadVariant113Action.Enable => "enable",
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
                "disable" => UserEventPayloadVariant113Action.Disable,
                "enable" => UserEventPayloadVariant113Action.Enable,
                _ => null,
            };
        }
    }
}