
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114Action
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
    public static class UserEventPayloadVariant114ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114Action value)
        {
            return value switch
            {
                UserEventPayloadVariant114Action.Disable => "disable",
                UserEventPayloadVariant114Action.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114Action? ToEnum(string value)
        {
            return value switch
            {
                "disable" => UserEventPayloadVariant114Action.Disable,
                "enable" => UserEventPayloadVariant114Action.Enable,
                _ => null,
            };
        }
    }
}