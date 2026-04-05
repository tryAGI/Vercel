
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ChecksConclusion
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
    public static class GetDeploymentResponseVariant2ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ChecksConclusion value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ChecksConclusion.Canceled => "canceled",
                GetDeploymentResponseVariant2ChecksConclusion.Failed => "failed",
                GetDeploymentResponseVariant2ChecksConclusion.Skipped => "skipped",
                GetDeploymentResponseVariant2ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentResponseVariant2ChecksConclusion.Canceled,
                "failed" => GetDeploymentResponseVariant2ChecksConclusion.Failed,
                "skipped" => GetDeploymentResponseVariant2ChecksConclusion.Skipped,
                "succeeded" => GetDeploymentResponseVariant2ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}