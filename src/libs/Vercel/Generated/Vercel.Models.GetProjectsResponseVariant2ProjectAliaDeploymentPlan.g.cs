
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentPlan
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Hobby => "hobby",
                GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Hobby,
                "pro" => GetProjectsResponseVariant2ProjectAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}