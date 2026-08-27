
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentPlan
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentPlan value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentPlan.Enterprise => "enterprise",
                UpdateMicrofrontendsResponseAliaDeploymentPlan.Hobby => "hobby",
                UpdateMicrofrontendsResponseAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateMicrofrontendsResponseAliaDeploymentPlan.Enterprise,
                "hobby" => UpdateMicrofrontendsResponseAliaDeploymentPlan.Hobby,
                "pro" => UpdateMicrofrontendsResponseAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}