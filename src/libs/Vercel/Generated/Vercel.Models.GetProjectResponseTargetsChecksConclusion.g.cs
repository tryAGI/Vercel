
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTargetsChecksConclusion
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
    public static class GetProjectResponseTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsChecksConclusion value)
        {
            return value switch
            {
                GetProjectResponseTargetsChecksConclusion.Canceled => "canceled",
                GetProjectResponseTargetsChecksConclusion.Failed => "failed",
                GetProjectResponseTargetsChecksConclusion.Skipped => "skipped",
                GetProjectResponseTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectResponseTargetsChecksConclusion.Canceled,
                "failed" => GetProjectResponseTargetsChecksConclusion.Failed,
                "skipped" => GetProjectResponseTargetsChecksConclusion.Skipped,
                "succeeded" => GetProjectResponseTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}