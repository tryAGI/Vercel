
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258Enabled
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
    public static class UserEventPayloadVariant258EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant258Enabled.Default => "default",
                UserEventPayloadVariant258Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant258Enabled.Off => "off",
                UserEventPayloadVariant258Enabled.OffForce => "off-force",
                UserEventPayloadVariant258Enabled.On => "on",
                UserEventPayloadVariant258Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant258Enabled.Default,
                "default-force" => UserEventPayloadVariant258Enabled.DefaultForce,
                "off" => UserEventPayloadVariant258Enabled.Off,
                "off-force" => UserEventPayloadVariant258Enabled.OffForce,
                "on" => UserEventPayloadVariant258Enabled.On,
                "on-force" => UserEventPayloadVariant258Enabled.OnForce,
                _ => null,
            };
        }
    }
}