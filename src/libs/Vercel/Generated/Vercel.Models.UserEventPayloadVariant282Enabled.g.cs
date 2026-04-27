
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282Enabled
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
    public static class UserEventPayloadVariant282EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant282Enabled.Default => "default",
                UserEventPayloadVariant282Enabled.Off => "off",
                UserEventPayloadVariant282Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant282Enabled.Default,
                "off" => UserEventPayloadVariant282Enabled.Off,
                "on" => UserEventPayloadVariant282Enabled.On,
                _ => null,
            };
        }
    }
}