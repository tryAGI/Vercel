
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288Enabled
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
    public static class UserEventPayloadVariant288EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant288Enabled.Default => "default",
                UserEventPayloadVariant288Enabled.Off => "off",
                UserEventPayloadVariant288Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant288Enabled.Default,
                "off" => UserEventPayloadVariant288Enabled.Off,
                "on" => UserEventPayloadVariant288Enabled.On,
                _ => null,
            };
        }
    }
}