
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ChecksConclusion
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
    public static class GetDeploymentResponseVariant1ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ChecksConclusion value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ChecksConclusion.Canceled => "canceled",
                GetDeploymentResponseVariant1ChecksConclusion.Failed => "failed",
                GetDeploymentResponseVariant1ChecksConclusion.Skipped => "skipped",
                GetDeploymentResponseVariant1ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentResponseVariant1ChecksConclusion.Canceled,
                "failed" => GetDeploymentResponseVariant1ChecksConclusion.Failed,
                "skipped" => GetDeploymentResponseVariant1ChecksConclusion.Skipped,
                "succeeded" => GetDeploymentResponseVariant1ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}