
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseTargetsChecksConclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsChecksConclusion value)
        {
            return value switch
            {
                CreateProjectResponseTargetsChecksConclusion.Canceled => "canceled",
                CreateProjectResponseTargetsChecksConclusion.Failed => "failed",
                CreateProjectResponseTargetsChecksConclusion.Skipped => "skipped",
                CreateProjectResponseTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateProjectResponseTargetsChecksConclusion.Canceled,
                "failed" => CreateProjectResponseTargetsChecksConclusion.Failed,
                "skipped" => CreateProjectResponseTargetsChecksConclusion.Skipped,
                "succeeded" => CreateProjectResponseTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}