
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTier
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
    public static class GetProjectsResponseVariant2ProjectTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTier value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTier.Advanced => "advanced",
                GetProjectsResponseVariant2ProjectTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant2ProjectTier.Advanced,
                "critical" => GetProjectsResponseVariant2ProjectTier.Critical,
                _ => null,
            };
        }
    }
}