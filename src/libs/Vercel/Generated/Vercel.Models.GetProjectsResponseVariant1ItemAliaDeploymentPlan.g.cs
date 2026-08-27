
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentPlan
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
    public static class GetProjectsResponseVariant1ItemAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentPlan value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentPlan.Enterprise => "enterprise",
                GetProjectsResponseVariant1ItemAliaDeploymentPlan.Hobby => "hobby",
                GetProjectsResponseVariant1ItemAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetProjectsResponseVariant1ItemAliaDeploymentPlan.Enterprise,
                "hobby" => GetProjectsResponseVariant1ItemAliaDeploymentPlan.Hobby,
                "pro" => GetProjectsResponseVariant1ItemAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}