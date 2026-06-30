
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentPlan
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentPlan value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentPlan.Enterprise => "enterprise",
                UpdateMicrofrontendsResponseLatestDeploymentPlan.Hobby => "hobby",
                UpdateMicrofrontendsResponseLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UpdateMicrofrontendsResponseLatestDeploymentPlan.Enterprise,
                "hobby" => UpdateMicrofrontendsResponseLatestDeploymentPlan.Hobby,
                "pro" => UpdateMicrofrontendsResponseLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}