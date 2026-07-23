
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant1ChecksConclusion
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
    public static class CreateDeploymentResponseVariant1ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant1ChecksConclusion value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant1ChecksConclusion.Canceled => "canceled",
                CreateDeploymentResponseVariant1ChecksConclusion.Failed => "failed",
                CreateDeploymentResponseVariant1ChecksConclusion.Skipped => "skipped",
                CreateDeploymentResponseVariant1ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant1ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentResponseVariant1ChecksConclusion.Canceled,
                "failed" => CreateDeploymentResponseVariant1ChecksConclusion.Failed,
                "skipped" => CreateDeploymentResponseVariant1ChecksConclusion.Skipped,
                "succeeded" => CreateDeploymentResponseVariant1ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}