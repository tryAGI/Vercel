
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274Enabled
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
    public static class UserEventPayloadVariant274EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant274Enabled.Default => "default",
                UserEventPayloadVariant274Enabled.Off => "off",
                UserEventPayloadVariant274Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant274Enabled.Default,
                "off" => UserEventPayloadVariant274Enabled.Off,
                "on" => UserEventPayloadVariant274Enabled.On,
                _ => null,
            };
        }
    }
}