
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentPlan
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Hobby => "hobby",
                GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Hobby,
                "pro" => GetProjectsResponseVariant3ProjectAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}