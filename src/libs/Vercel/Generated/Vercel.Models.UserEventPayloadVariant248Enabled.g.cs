
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant248Enabled
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
    public static class UserEventPayloadVariant248EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant248Enabled.Default => "default",
                UserEventPayloadVariant248Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant248Enabled.Off => "off",
                UserEventPayloadVariant248Enabled.OffForce => "off-force",
                UserEventPayloadVariant248Enabled.On => "on",
                UserEventPayloadVariant248Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant248Enabled.Default,
                "default-force" => UserEventPayloadVariant248Enabled.DefaultForce,
                "off" => UserEventPayloadVariant248Enabled.Off,
                "off-force" => UserEventPayloadVariant248Enabled.OffForce,
                "on" => UserEventPayloadVariant248Enabled.On,
                "on-force" => UserEventPayloadVariant248Enabled.OnForce,
                _ => null,
            };
        }
    }
}