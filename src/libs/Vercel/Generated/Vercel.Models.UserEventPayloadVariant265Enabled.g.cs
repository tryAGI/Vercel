
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265Enabled
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
    public static class UserEventPayloadVariant265EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant265Enabled.Default => "default",
                UserEventPayloadVariant265Enabled.Off => "off",
                UserEventPayloadVariant265Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant265Enabled.Default,
                "off" => UserEventPayloadVariant265Enabled.Off,
                "on" => UserEventPayloadVariant265Enabled.On,
                _ => null,
            };
        }
    }
}