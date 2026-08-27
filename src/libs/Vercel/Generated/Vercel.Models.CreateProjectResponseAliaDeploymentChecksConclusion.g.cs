
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentChecksConclusion
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
    public static class CreateProjectResponseAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentChecksConclusion.Canceled => "canceled",
                CreateProjectResponseAliaDeploymentChecksConclusion.Failed => "failed",
                CreateProjectResponseAliaDeploymentChecksConclusion.Skipped => "skipped",
                CreateProjectResponseAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateProjectResponseAliaDeploymentChecksConclusion.Canceled,
                "failed" => CreateProjectResponseAliaDeploymentChecksConclusion.Failed,
                "skipped" => CreateProjectResponseAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => CreateProjectResponseAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}