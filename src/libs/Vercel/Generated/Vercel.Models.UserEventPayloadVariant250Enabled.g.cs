
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Enabled
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
    public static class UserEventPayloadVariant250EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant250Enabled.Default => "default",
                UserEventPayloadVariant250Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant250Enabled.Off => "off",
                UserEventPayloadVariant250Enabled.OffForce => "off-force",
                UserEventPayloadVariant250Enabled.On => "on",
                UserEventPayloadVariant250Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant250Enabled.Default,
                "default-force" => UserEventPayloadVariant250Enabled.DefaultForce,
                "off" => UserEventPayloadVariant250Enabled.Off,
                "off-force" => UserEventPayloadVariant250Enabled.OffForce,
                "on" => UserEventPayloadVariant250Enabled.On,
                "on-force" => UserEventPayloadVariant250Enabled.OnForce,
                _ => null,
            };
        }
    }
}