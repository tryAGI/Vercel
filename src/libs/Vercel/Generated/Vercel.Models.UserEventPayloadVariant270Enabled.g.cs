
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270Enabled
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant270EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant270Enabled.Default => "default",
                UserEventPayloadVariant270Enabled.Off => "off",
                UserEventPayloadVariant270Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant270Enabled.Default,
                "off" => UserEventPayloadVariant270Enabled.Off,
                "on" => UserEventPayloadVariant270Enabled.On,
                _ => null,
            };
        }
    }
}