
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectFlatRateTier
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
    public static class GetProjectsResponseVariant3ProjectFlatRateTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectFlatRateTier value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectFlatRateTier.Advanced => "advanced",
                GetProjectsResponseVariant3ProjectFlatRateTier.Base => "base",
                GetProjectsResponseVariant3ProjectFlatRateTier.Critical => "critical",
                GetProjectsResponseVariant3ProjectFlatRateTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectFlatRateTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant3ProjectFlatRateTier.Advanced,
                "base" => GetProjectsResponseVariant3ProjectFlatRateTier.Base,
                "critical" => GetProjectsResponseVariant3ProjectFlatRateTier.Critical,
                "standard" => GetProjectsResponseVariant3ProjectFlatRateTier.Standard,
                _ => null,
            };
        }
    }
}