
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseChecksConclusion
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
    public static class CreateDeploymentResponseChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseChecksConclusion value)
        {
            return value switch
            {
                CreateDeploymentResponseChecksConclusion.Canceled => "canceled",
                CreateDeploymentResponseChecksConclusion.Failed => "failed",
                CreateDeploymentResponseChecksConclusion.Skipped => "skipped",
                CreateDeploymentResponseChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentResponseChecksConclusion.Canceled,
                "failed" => CreateDeploymentResponseChecksConclusion.Failed,
                "skipped" => CreateDeploymentResponseChecksConclusion.Skipped,
                "succeeded" => CreateDeploymentResponseChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}