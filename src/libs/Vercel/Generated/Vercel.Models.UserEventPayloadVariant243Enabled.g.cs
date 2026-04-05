
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant243Enabled
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        DefaultForce,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        OffForce,
        /// <summary>
        /// 
        /// </summary>
        On,
        /// <summary>
        /// 
        /// </summary>
        OnForce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant243EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant243Enabled.Default => "default",
                UserEventPayloadVariant243Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant243Enabled.Off => "off",
                UserEventPayloadVariant243Enabled.OffForce => "off-force",
                UserEventPayloadVariant243Enabled.On => "on",
                UserEventPayloadVariant243Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant243Enabled.Default,
                "default-force" => UserEventPayloadVariant243Enabled.DefaultForce,
                "off" => UserEventPayloadVariant243Enabled.Off,
                "off-force" => UserEventPayloadVariant243Enabled.OffForce,
                "on" => UserEventPayloadVariant243Enabled.On,
                "on-force" => UserEventPayloadVariant243Enabled.OnForce,
                _ => null,
            };
        }
    }
}