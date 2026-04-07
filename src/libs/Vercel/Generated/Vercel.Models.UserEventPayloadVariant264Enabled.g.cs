
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Enabled
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
    public static class UserEventPayloadVariant264EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant264Enabled.Default => "default",
                UserEventPayloadVariant264Enabled.Off => "off",
                UserEventPayloadVariant264Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant264Enabled.Default,
                "off" => UserEventPayloadVariant264Enabled.Off,
                "on" => UserEventPayloadVariant264Enabled.On,
                _ => null,
            };
        }
    }
}