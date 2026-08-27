
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseLatestDeploymentPlan
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Hobby,
        /// <summary>
        ///
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentPlan value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentPlan.Enterprise => "enterprise",
                GetProjectResponseLatestDeploymentPlan.Hobby => "hobby",
                GetProjectResponseLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectResponseLatestDeploymentPlan.Enterprise,
                "hobby" => GetProjectResponseLatestDeploymentPlan.Hobby,
                "pro" => GetProjectResponseLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}