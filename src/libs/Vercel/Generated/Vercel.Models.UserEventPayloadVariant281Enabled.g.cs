
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant281Enabled
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
    public static class UserEventPayloadVariant281EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant281Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant281Enabled.Default => "default",
                UserEventPayloadVariant281Enabled.Off => "off",
                UserEventPayloadVariant281Enabled.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant281Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant281Enabled.Default,
                "off" => UserEventPayloadVariant281Enabled.Off,
                "on" => UserEventPayloadVariant281Enabled.On,
                _ => null,
            };
        }
    }
}