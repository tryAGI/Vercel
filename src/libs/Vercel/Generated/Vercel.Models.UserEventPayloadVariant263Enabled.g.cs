
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant263Enabled
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
    public static class UserEventPayloadVariant263EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant263Enabled.Default => "default",
                UserEventPayloadVariant263Enabled.Off => "off",
                UserEventPayloadVariant263Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant263Enabled.Default,
                "off" => UserEventPayloadVariant263Enabled.Off,
                "on" => UserEventPayloadVariant263Enabled.On,
                _ => null,
            };
        }
    }
}