
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseFlatRateTier
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
    public static class GetProjectResponseFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseFlatRateTier value)
        {
            return value switch
            {
                GetProjectResponseFlatRateTier.Advanced => "advanced",
                GetProjectResponseFlatRateTier.Base => "base",
                GetProjectResponseFlatRateTier.Critical => "critical",
                GetProjectResponseFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectResponseFlatRateTier.Advanced,
                "base" => GetProjectResponseFlatRateTier.Base,
                "critical" => GetProjectResponseFlatRateTier.Critical,
                "standard" => GetProjectResponseFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}