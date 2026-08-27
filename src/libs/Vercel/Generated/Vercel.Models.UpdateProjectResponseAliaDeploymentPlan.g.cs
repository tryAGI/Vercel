
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseAliaDeploymentPlan
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
    public static class UpdateProjectResponseAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaDeploymentPlan value)
        {
            return value switch
            {
                UpdateProjectResponseAliaDeploymentPlan.Enterprise => "enterprise",
                UpdateProjectResponseAliaDeploymentPlan.Hobby => "hobby",
                UpdateProjectResponseAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateProjectResponseAliaDeploymentPlan.Enterprise,
                "hobby" => UpdateProjectResponseAliaDeploymentPlan.Hobby,
                "pro" => UpdateProjectResponseAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}