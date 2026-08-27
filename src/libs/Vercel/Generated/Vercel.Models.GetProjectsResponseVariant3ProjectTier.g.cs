
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTier
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
    public static class GetProjectsResponseVariant3ProjectTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTier value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTier.Advanced => "advanced",
                GetProjectsResponseVariant3ProjectTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant3ProjectTier.Advanced,
                "critical" => GetProjectsResponseVariant3ProjectTier.Critical,
                _ => null,
            };
        }
    }
}