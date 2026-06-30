
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsChecksConclusion
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
    public static class GetProjectsResponseVariant2ProjectTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant2ProjectTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}