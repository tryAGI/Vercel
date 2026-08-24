
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTier
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Critical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTier value)
        {
            return value switch
            {
                UpdateProjectResponseTier.Advanced => "advanced",
                UpdateProjectResponseTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UpdateProjectResponseTier.Advanced,
                "critical" => UpdateProjectResponseTier.Critical,
                _ => null,
            };
        }
    }
}