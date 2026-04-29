
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant120Action
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
    public static class UserEventPayloadVariant120ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant120Action value)
        {
            return value switch
            {
                UserEventPayloadVariant120Action.Disable => "disable",
                UserEventPayloadVariant120Action.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant120Action? ToEnum(string value)
        {
            return value switch
            {
                "disable" => UserEventPayloadVariant120Action.Disable,
                "enable" => UserEventPayloadVariant120Action.Enable,
                _ => null,
            };
        }
    }
}