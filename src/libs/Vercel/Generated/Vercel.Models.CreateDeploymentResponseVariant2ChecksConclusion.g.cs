
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2ChecksConclusion
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
    public static class CreateDeploymentResponseVariant2ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ChecksConclusion value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ChecksConclusion.Canceled => "canceled",
                CreateDeploymentResponseVariant2ChecksConclusion.Failed => "failed",
                CreateDeploymentResponseVariant2ChecksConclusion.Skipped => "skipped",
                CreateDeploymentResponseVariant2ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentResponseVariant2ChecksConclusion.Canceled,
                "failed" => CreateDeploymentResponseVariant2ChecksConclusion.Failed,
                "skipped" => CreateDeploymentResponseVariant2ChecksConclusion.Skipped,
                "succeeded" => CreateDeploymentResponseVariant2ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}