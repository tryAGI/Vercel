
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant292Enabled
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
    public static class UserEventPayloadVariant292EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant292Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant292Enabled.Default => "default",
                UserEventPayloadVariant292Enabled.Off => "off",
                UserEventPayloadVariant292Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant292Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant292Enabled.Default,
                "off" => UserEventPayloadVariant292Enabled.Off,
                "on" => UserEventPayloadVariant292Enabled.On,
                _ => null,
            };
        }
    }
}