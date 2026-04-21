
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276Enabled
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
    public static class UserEventPayloadVariant276EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant276Enabled.Default => "default",
                UserEventPayloadVariant276Enabled.Off => "off",
                UserEventPayloadVariant276Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant276Enabled.Default,
                "off" => UserEventPayloadVariant276Enabled.Off,
                "on" => UserEventPayloadVariant276Enabled.On,
                _ => null,
            };
        }
    }
}