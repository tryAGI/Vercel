
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsChecksConclusion
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
    public static class GetProjectsResponseVariant1ItemTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant1ItemTargetsChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant1ItemTargetsChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant1ItemTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant1ItemTargetsChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant1ItemTargetsChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant1ItemTargetsChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant1ItemTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}