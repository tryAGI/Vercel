
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponseVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        OverLimit,
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseVariant2Status value)
        {
            return value switch
            {
                StatusResponseVariant2Status.Disabled => "disabled",
                StatusResponseVariant2Status.Enabled => "enabled",
                StatusResponseVariant2Status.OverLimit => "over_limit",
                StatusResponseVariant2Status.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => StatusResponseVariant2Status.Disabled,
                "enabled" => StatusResponseVariant2Status.Enabled,
                "over_limit" => StatusResponseVariant2Status.OverLimit,
                "paused" => StatusResponseVariant2Status.Paused,
                _ => null,
            };
        }
    }
}