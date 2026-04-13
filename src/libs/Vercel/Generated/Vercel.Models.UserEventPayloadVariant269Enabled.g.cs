
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
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
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
                UserEventPayloadVariant269Enabled.Off => "off",
                UserEventPayloadVariant269Enabled.On => "on",
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
                "off" => UserEventPayloadVariant269Enabled.Off,
                "on" => UserEventPayloadVariant269Enabled.On,
                _ => null,
            };
        }
    }
}