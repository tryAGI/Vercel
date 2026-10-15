
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum StatusResponseVariant3Status
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
    public static class StatusResponseVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseVariant3Status value)
        {
            return value switch
            {
                StatusResponseVariant3Status.Disabled => "disabled",
                StatusResponseVariant3Status.Enabled => "enabled",
                StatusResponseVariant3Status.OverLimit => "over_limit",
                StatusResponseVariant3Status.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => StatusResponseVariant3Status.Disabled,
                "enabled" => StatusResponseVariant3Status.Enabled,
                "over_limit" => StatusResponseVariant3Status.OverLimit,
                "paused" => StatusResponseVariant3Status.Paused,
                _ => null,
            };
        }
    }
}