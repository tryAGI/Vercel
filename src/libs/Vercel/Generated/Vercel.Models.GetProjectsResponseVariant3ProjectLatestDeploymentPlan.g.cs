
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentPlan
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
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Hobby => "hobby",
                GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Hobby,
                "pro" => GetProjectsResponseVariant3ProjectLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}