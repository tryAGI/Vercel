
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant266Enabled
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
    public static class UserEventPayloadVariant266EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant266Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant266Enabled.Default => "default",
                UserEventPayloadVariant266Enabled.Off => "off",
                UserEventPayloadVariant266Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant266Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant266Enabled.Default,
                "off" => UserEventPayloadVariant266Enabled.Off,
                "on" => UserEventPayloadVariant266Enabled.On,
                _ => null,
            };
        }
    }
}