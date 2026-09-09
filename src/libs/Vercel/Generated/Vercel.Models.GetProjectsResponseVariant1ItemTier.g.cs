
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
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
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
                GetProjectsResponseVariant1ItemTier.Critical => "critical",
                GetProjectsResponseVariant1ItemTier.Priority => "priority",
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
                "critical" => GetProjectsResponseVariant1ItemTier.Critical,
                "priority" => GetProjectsResponseVariant1ItemTier.Priority,
                _ => null,
            };
        }
    }
}