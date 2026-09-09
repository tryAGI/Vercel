
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseTier
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
    public static class CreateProjectResponseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTier value)
        {
            return value switch
            {
                CreateProjectResponseTier.Critical => "critical",
                CreateProjectResponseTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTier? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CreateProjectResponseTier.Critical,
                "priority" => CreateProjectResponseTier.Priority,
                _ => null,
            };
        }
    }
}