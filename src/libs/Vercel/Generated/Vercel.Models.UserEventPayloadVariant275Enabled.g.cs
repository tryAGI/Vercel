
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275Enabled
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
    public static class UserEventPayloadVariant275EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant275Enabled.Default => "default",
                UserEventPayloadVariant275Enabled.Off => "off",
                UserEventPayloadVariant275Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant275Enabled.Default,
                "off" => UserEventPayloadVariant275Enabled.Off,
                "on" => UserEventPayloadVariant275Enabled.On,
                _ => null,
            };
        }
    }
}