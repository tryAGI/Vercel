
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseTier
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTier value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTier.Advanced => "advanced",
                UpdateMicrofrontendsResponseTier.Critical => "critical",
                UpdateMicrofrontendsResponseTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UpdateMicrofrontendsResponseTier.Advanced,
                "critical" => UpdateMicrofrontendsResponseTier.Critical,
                "priority" => UpdateMicrofrontendsResponseTier.Priority,
                _ => null,
            };
        }
    }
}