
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant280Enabled
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
    public static class UserEventPayloadVariant280EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant280Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant280Enabled.Default => "default",
                UserEventPayloadVariant280Enabled.Off => "off",
                UserEventPayloadVariant280Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant280Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant280Enabled.Default,
                "off" => UserEventPayloadVariant280Enabled.Off,
                "on" => UserEventPayloadVariant280Enabled.On,
                _ => null,
            };
        }
    }
}