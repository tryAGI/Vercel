
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant269Enabled
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
    public static class UserEventPayloadVariant269EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant269Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant269Enabled.Default => "default",
                UserEventPayloadVariant269Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant269Enabled.Off => "off",
                UserEventPayloadVariant269Enabled.OffForce => "off-force",
                UserEventPayloadVariant269Enabled.On => "on",
                UserEventPayloadVariant269Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant269Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant269Enabled.Default,
                "default-force" => UserEventPayloadVariant269Enabled.DefaultForce,
                "off" => UserEventPayloadVariant269Enabled.Off,
                "off-force" => UserEventPayloadVariant269Enabled.OffForce,
                "on" => UserEventPayloadVariant269Enabled.On,
                "on-force" => UserEventPayloadVariant269Enabled.OnForce,
                _ => null,
            };
        }
    }
}