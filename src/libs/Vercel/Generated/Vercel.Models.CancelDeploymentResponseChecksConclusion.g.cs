
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseChecksConclusion
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
    public static class CancelDeploymentResponseChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseChecksConclusion value)
        {
            return value switch
            {
                CancelDeploymentResponseChecksConclusion.Canceled => "canceled",
                CancelDeploymentResponseChecksConclusion.Failed => "failed",
                CancelDeploymentResponseChecksConclusion.Skipped => "skipped",
                CancelDeploymentResponseChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CancelDeploymentResponseChecksConclusion.Canceled,
                "failed" => CancelDeploymentResponseChecksConclusion.Failed,
                "skipped" => CancelDeploymentResponseChecksConclusion.Skipped,
                "succeeded" => CancelDeploymentResponseChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}