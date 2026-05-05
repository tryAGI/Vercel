
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270Enabled
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
    public static class UserEventPayloadVariant270EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant270Enabled.Default => "default",
                UserEventPayloadVariant270Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant270Enabled.Off => "off",
                UserEventPayloadVariant270Enabled.OffForce => "off-force",
                UserEventPayloadVariant270Enabled.On => "on",
                UserEventPayloadVariant270Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant270Enabled.Default,
                "default-force" => UserEventPayloadVariant270Enabled.DefaultForce,
                "off" => UserEventPayloadVariant270Enabled.Off,
                "off-force" => UserEventPayloadVariant270Enabled.OffForce,
                "on" => UserEventPayloadVariant270Enabled.On,
                "on-force" => UserEventPayloadVariant270Enabled.OnForce,
                _ => null,
            };
        }
    }
}