
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion
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
    public static class GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Canceled => "canceled",
                GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Failed => "failed",
                GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Skipped => "skipped",
                GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Canceled,
                "failed" => GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Failed,
                "skipped" => GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Skipped,
                "succeeded" => GetMicrofrontendsInGroupResponseProjectTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}