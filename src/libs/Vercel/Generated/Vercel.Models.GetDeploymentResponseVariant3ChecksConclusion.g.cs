
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant3ChecksConclusion
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
    public static class GetDeploymentResponseVariant3ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3ChecksConclusion value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3ChecksConclusion.Canceled => "canceled",
                GetDeploymentResponseVariant3ChecksConclusion.Failed => "failed",
                GetDeploymentResponseVariant3ChecksConclusion.Skipped => "skipped",
                GetDeploymentResponseVariant3ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentResponseVariant3ChecksConclusion.Canceled,
                "failed" => GetDeploymentResponseVariant3ChecksConclusion.Failed,
                "skipped" => GetDeploymentResponseVariant3ChecksConclusion.Skipped,
                "succeeded" => GetDeploymentResponseVariant3ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}