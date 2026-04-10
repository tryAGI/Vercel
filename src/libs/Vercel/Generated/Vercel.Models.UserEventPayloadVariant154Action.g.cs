
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant154Action
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant154ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant154Action value)
        {
            return value switch
            {
                UserEventPayloadVariant154Action.Disabled => "disabled",
                UserEventPayloadVariant154Action.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant154Action? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant154Action.Disabled,
                "enabled" => UserEventPayloadVariant154Action.Enabled,
                _ => null,
            };
        }
    }
}