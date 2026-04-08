
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Enabled
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
    public static class UserEventPayloadVariant245EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant245Enabled.Default => "default",
                UserEventPayloadVariant245Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant245Enabled.Off => "off",
                UserEventPayloadVariant245Enabled.OffForce => "off-force",
                UserEventPayloadVariant245Enabled.On => "on",
                UserEventPayloadVariant245Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant245Enabled.Default,
                "default-force" => UserEventPayloadVariant245Enabled.DefaultForce,
                "off" => UserEventPayloadVariant245Enabled.Off,
                "off-force" => UserEventPayloadVariant245Enabled.OffForce,
                "on" => UserEventPayloadVariant245Enabled.On,
                "on-force" => UserEventPayloadVariant245Enabled.OnForce,
                _ => null,
            };
        }
    }
}