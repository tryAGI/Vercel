
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Enabled
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
    public static class UserEventPayloadVariant244EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant244Enabled.Default => "default",
                UserEventPayloadVariant244Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant244Enabled.Off => "off",
                UserEventPayloadVariant244Enabled.OffForce => "off-force",
                UserEventPayloadVariant244Enabled.On => "on",
                UserEventPayloadVariant244Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant244Enabled.Default,
                "default-force" => UserEventPayloadVariant244Enabled.DefaultForce,
                "off" => UserEventPayloadVariant244Enabled.Off,
                "off-force" => UserEventPayloadVariant244Enabled.OffForce,
                "on" => UserEventPayloadVariant244Enabled.On,
                "on-force" => UserEventPayloadVariant244Enabled.OnForce,
                _ => null,
            };
        }
    }
}