
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentPlan
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
    public static class CreateProjectResponseLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentPlan value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentPlan.Enterprise => "enterprise",
                CreateProjectResponseLatestDeploymentPlan.Hobby => "hobby",
                CreateProjectResponseLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CreateProjectResponseLatestDeploymentPlan.Enterprise,
                "hobby" => CreateProjectResponseLatestDeploymentPlan.Hobby,
                "pro" => CreateProjectResponseLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}