
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant267Enabled
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
    public static class UserEventPayloadVariant267EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant267Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant267Enabled.Default => "default",
                UserEventPayloadVariant267Enabled.Off => "off",
                UserEventPayloadVariant267Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant267Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant267Enabled.Default,
                "off" => UserEventPayloadVariant267Enabled.Off,
                "on" => UserEventPayloadVariant267Enabled.On,
                _ => null,
            };
        }
    }
}