
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLatestDeploymentPlan
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
    public static class GetProjectsResponseVariant2ProjectLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLatestDeploymentPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Hobby => "hobby",
                GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Hobby,
                "pro" => GetProjectsResponseVariant2ProjectLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}