
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant278Enabled
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
    public static class UserEventPayloadVariant278EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant278Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant278Enabled.Default => "default",
                UserEventPayloadVariant278Enabled.Off => "off",
                UserEventPayloadVariant278Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant278Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant278Enabled.Default,
                "off" => UserEventPayloadVariant278Enabled.Off,
                "on" => UserEventPayloadVariant278Enabled.On,
                _ => null,
            };
        }
    }
}