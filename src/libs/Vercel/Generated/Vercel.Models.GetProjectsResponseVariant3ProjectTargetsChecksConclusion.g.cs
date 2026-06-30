
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsChecksConclusion
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
    public static class GetProjectsResponseVariant3ProjectTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant3ProjectTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}