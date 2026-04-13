
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249Enabled
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
    public static class UserEventPayloadVariant249EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant249Enabled.Default => "default",
                UserEventPayloadVariant249Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant249Enabled.Off => "off",
                UserEventPayloadVariant249Enabled.OffForce => "off-force",
                UserEventPayloadVariant249Enabled.On => "on",
                UserEventPayloadVariant249Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant249Enabled.Default,
                "default-force" => UserEventPayloadVariant249Enabled.DefaultForce,
                "off" => UserEventPayloadVariant249Enabled.Off,
                "off-force" => UserEventPayloadVariant249Enabled.OffForce,
                "on" => UserEventPayloadVariant249Enabled.On,
                "on-force" => UserEventPayloadVariant249Enabled.OnForce,
                _ => null,
            };
        }
    }
}