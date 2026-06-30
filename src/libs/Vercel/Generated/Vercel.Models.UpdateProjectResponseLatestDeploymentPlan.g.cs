
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentPlan
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
    public static class UpdateProjectResponseLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentPlan value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentPlan.Enterprise => "enterprise",
                UpdateProjectResponseLatestDeploymentPlan.Hobby => "hobby",
                UpdateProjectResponseLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateProjectResponseLatestDeploymentPlan.Enterprise,
                "hobby" => UpdateProjectResponseLatestDeploymentPlan.Hobby,
                "pro" => UpdateProjectResponseLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}