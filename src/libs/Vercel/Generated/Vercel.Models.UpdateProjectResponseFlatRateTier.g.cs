
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseFlatRateTier
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseFlatRateTier value)
        {
            return value switch
            {
                UpdateProjectResponseFlatRateTier.Advanced => "advanced",
                UpdateProjectResponseFlatRateTier.Base => "base",
                UpdateProjectResponseFlatRateTier.Critical => "critical",
                UpdateProjectResponseFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UpdateProjectResponseFlatRateTier.Advanced,
                "base" => UpdateProjectResponseFlatRateTier.Base,
                "critical" => UpdateProjectResponseFlatRateTier.Critical,
                "standard" => UpdateProjectResponseFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}