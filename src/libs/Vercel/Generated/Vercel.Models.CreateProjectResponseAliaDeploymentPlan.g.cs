
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentPlan
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
    public static class CreateProjectResponseAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentPlan value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentPlan.Enterprise => "enterprise",
                CreateProjectResponseAliaDeploymentPlan.Hobby => "hobby",
                CreateProjectResponseAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CreateProjectResponseAliaDeploymentPlan.Enterprise,
                "hobby" => CreateProjectResponseAliaDeploymentPlan.Hobby,
                "pro" => CreateProjectResponseAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}