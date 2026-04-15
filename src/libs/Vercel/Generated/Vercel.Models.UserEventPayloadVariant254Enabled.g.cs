
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254Enabled
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
    public static class UserEventPayloadVariant254EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant254Enabled.Default => "default",
                UserEventPayloadVariant254Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant254Enabled.Off => "off",
                UserEventPayloadVariant254Enabled.OffForce => "off-force",
                UserEventPayloadVariant254Enabled.On => "on",
                UserEventPayloadVariant254Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant254Enabled.Default,
                "default-force" => UserEventPayloadVariant254Enabled.DefaultForce,
                "off" => UserEventPayloadVariant254Enabled.Off,
                "off-force" => UserEventPayloadVariant254Enabled.OffForce,
                "on" => UserEventPayloadVariant254Enabled.On,
                "on-force" => UserEventPayloadVariant254Enabled.OnForce,
                _ => null,
            };
        }
    }
}