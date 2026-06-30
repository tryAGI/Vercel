
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAliaDeploymentPlan
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
    public static class GetProjectResponseAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentPlan value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentPlan.Enterprise => "enterprise",
                GetProjectResponseAliaDeploymentPlan.Hobby => "hobby",
                GetProjectResponseAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectResponseAliaDeploymentPlan.Enterprise,
                "hobby" => GetProjectResponseAliaDeploymentPlan.Hobby,
                "pro" => GetProjectResponseAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}