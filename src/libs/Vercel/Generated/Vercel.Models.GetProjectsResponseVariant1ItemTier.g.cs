
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTier
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
    public static class GetProjectsResponseVariant1ItemTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTier value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTier.Advanced => "advanced",
                GetProjectsResponseVariant1ItemTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant1ItemTier.Advanced,
                "critical" => GetProjectsResponseVariant1ItemTier.Critical,
                _ => null,
            };
        }
    }
}