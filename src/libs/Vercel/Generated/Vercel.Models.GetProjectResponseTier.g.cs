
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseTier
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
    public static class GetProjectResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTier value)
        {
            return value switch
            {
                GetProjectResponseTier.Advanced => "advanced",
                GetProjectResponseTier.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectResponseTier.Advanced,
                "critical" => GetProjectResponseTier.Critical,
                _ => null,
            };
        }
    }
}