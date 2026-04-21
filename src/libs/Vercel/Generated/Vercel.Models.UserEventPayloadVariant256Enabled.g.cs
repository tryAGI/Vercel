
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256Enabled
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
    public static class UserEventPayloadVariant256EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant256Enabled.Default => "default",
                UserEventPayloadVariant256Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant256Enabled.Off => "off",
                UserEventPayloadVariant256Enabled.OffForce => "off-force",
                UserEventPayloadVariant256Enabled.On => "on",
                UserEventPayloadVariant256Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant256Enabled.Default,
                "default-force" => UserEventPayloadVariant256Enabled.DefaultForce,
                "off" => UserEventPayloadVariant256Enabled.Off,
                "off-force" => UserEventPayloadVariant256Enabled.OffForce,
                "on" => UserEventPayloadVariant256Enabled.On,
                "on-force" => UserEventPayloadVariant256Enabled.OnForce,
                _ => null,
            };
        }
    }
}