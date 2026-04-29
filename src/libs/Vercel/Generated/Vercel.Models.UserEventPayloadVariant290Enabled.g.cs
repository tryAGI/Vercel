
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290Enabled
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
    public static class UserEventPayloadVariant290EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant290Enabled.Default => "default",
                UserEventPayloadVariant290Enabled.Off => "off",
                UserEventPayloadVariant290Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant290Enabled.Default,
                "off" => UserEventPayloadVariant290Enabled.Off,
                "on" => UserEventPayloadVariant290Enabled.On,
                _ => null,
            };
        }
    }
}