
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant259Enabled
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
    public static class UserEventPayloadVariant259EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant259Enabled.Default => "default",
                UserEventPayloadVariant259Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant259Enabled.Off => "off",
                UserEventPayloadVariant259Enabled.OffForce => "off-force",
                UserEventPayloadVariant259Enabled.On => "on",
                UserEventPayloadVariant259Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant259Enabled.Default,
                "default-force" => UserEventPayloadVariant259Enabled.DefaultForce,
                "off" => UserEventPayloadVariant259Enabled.Off,
                "off-force" => UserEventPayloadVariant259Enabled.OffForce,
                "on" => UserEventPayloadVariant259Enabled.On,
                "on-force" => UserEventPayloadVariant259Enabled.OnForce,
                _ => null,
            };
        }
    }
}