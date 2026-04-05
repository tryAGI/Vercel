
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Conclusion for checks
    /// </summary>
    public enum GetDeploymentsResponseDeploymentChecksConclusion
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
    public static class GetDeploymentsResponseDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentChecksConclusion.Canceled => "canceled",
                GetDeploymentsResponseDeploymentChecksConclusion.Failed => "failed",
                GetDeploymentsResponseDeploymentChecksConclusion.Skipped => "skipped",
                GetDeploymentsResponseDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentsResponseDeploymentChecksConclusion.Canceled,
                "failed" => GetDeploymentsResponseDeploymentChecksConclusion.Failed,
                "skipped" => GetDeploymentsResponseDeploymentChecksConclusion.Skipped,
                "succeeded" => GetDeploymentsResponseDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}