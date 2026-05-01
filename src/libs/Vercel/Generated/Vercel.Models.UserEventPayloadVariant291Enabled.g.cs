
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant291Enabled
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
    public static class UserEventPayloadVariant291EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant291Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant291Enabled.Default => "default",
                UserEventPayloadVariant291Enabled.Off => "off",
                UserEventPayloadVariant291Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant291Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant291Enabled.Default,
                "off" => UserEventPayloadVariant291Enabled.Off,
                "on" => UserEventPayloadVariant291Enabled.On,
                _ => null,
            };
        }
    }
}