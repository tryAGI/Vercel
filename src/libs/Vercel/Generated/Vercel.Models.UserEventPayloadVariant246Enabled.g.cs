
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Enabled
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
    public static class UserEventPayloadVariant246EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant246Enabled.Default => "default",
                UserEventPayloadVariant246Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant246Enabled.Off => "off",
                UserEventPayloadVariant246Enabled.OffForce => "off-force",
                UserEventPayloadVariant246Enabled.On => "on",
                UserEventPayloadVariant246Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant246Enabled.Default,
                "default-force" => UserEventPayloadVariant246Enabled.DefaultForce,
                "off" => UserEventPayloadVariant246Enabled.Off,
                "off-force" => UserEventPayloadVariant246Enabled.OffForce,
                "on" => UserEventPayloadVariant246Enabled.On,
                "on-force" => UserEventPayloadVariant246Enabled.OnForce,
                _ => null,
            };
        }
    }
}