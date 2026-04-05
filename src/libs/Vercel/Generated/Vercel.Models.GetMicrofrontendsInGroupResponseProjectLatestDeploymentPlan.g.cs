
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Enterprise => "enterprise",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Hobby => "hobby",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Enterprise,
                "hobby" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Hobby,
                "pro" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}