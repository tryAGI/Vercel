
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260Enabled
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
    public static class UserEventPayloadVariant260EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant260Enabled.Default => "default",
                UserEventPayloadVariant260Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant260Enabled.Off => "off",
                UserEventPayloadVariant260Enabled.OffForce => "off-force",
                UserEventPayloadVariant260Enabled.On => "on",
                UserEventPayloadVariant260Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant260Enabled.Default,
                "default-force" => UserEventPayloadVariant260Enabled.DefaultForce,
                "off" => UserEventPayloadVariant260Enabled.Off,
                "off-force" => UserEventPayloadVariant260Enabled.OffForce,
                "on" => UserEventPayloadVariant260Enabled.On,
                "on-force" => UserEventPayloadVariant260Enabled.OnForce,
                _ => null,
            };
        }
    }
}