
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268Enabled
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
    public static class UserEventPayloadVariant268EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant268Enabled.Default => "default",
                UserEventPayloadVariant268Enabled.Off => "off",
                UserEventPayloadVariant268Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant268Enabled.Default,
                "off" => UserEventPayloadVariant268Enabled.Off,
                "on" => UserEventPayloadVariant268Enabled.On,
                _ => null,
            };
        }
    }
}