
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
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
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
                GetProjectsResponseVariant2ProjectTier.Critical => "critical",
                GetProjectsResponseVariant2ProjectTier.Priority => "priority",
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
                "critical" => GetProjectsResponseVariant2ProjectTier.Critical,
                "priority" => GetProjectsResponseVariant2ProjectTier.Priority,
                _ => null,
            };
        }
    }
}