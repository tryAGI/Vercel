
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseFlatRateTier
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
    public static class CreateProjectResponseFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseFlatRateTier value)
        {
            return value switch
            {
                CreateProjectResponseFlatRateTier.Advanced => "advanced",
                CreateProjectResponseFlatRateTier.Base => "base",
                CreateProjectResponseFlatRateTier.Critical => "critical",
                CreateProjectResponseFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateProjectResponseFlatRateTier.Advanced,
                "base" => CreateProjectResponseFlatRateTier.Base,
                "critical" => CreateProjectResponseFlatRateTier.Critical,
                "standard" => CreateProjectResponseFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}