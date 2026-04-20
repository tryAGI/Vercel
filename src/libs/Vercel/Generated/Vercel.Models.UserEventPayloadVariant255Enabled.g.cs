
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Enabled
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
    public static class UserEventPayloadVariant255EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant255Enabled.Default => "default",
                UserEventPayloadVariant255Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant255Enabled.Off => "off",
                UserEventPayloadVariant255Enabled.OffForce => "off-force",
                UserEventPayloadVariant255Enabled.On => "on",
                UserEventPayloadVariant255Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant255Enabled.Default,
                "default-force" => UserEventPayloadVariant255Enabled.DefaultForce,
                "off" => UserEventPayloadVariant255Enabled.Off,
                "off-force" => UserEventPayloadVariant255Enabled.OffForce,
                "on" => UserEventPayloadVariant255Enabled.On,
                "on-force" => UserEventPayloadVariant255Enabled.OnForce,
                _ => null,
            };
        }
    }
}