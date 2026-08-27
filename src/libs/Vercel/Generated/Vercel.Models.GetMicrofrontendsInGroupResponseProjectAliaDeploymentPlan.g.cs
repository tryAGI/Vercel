
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan
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
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Enterprise => "enterprise",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Hobby => "hobby",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Enterprise,
                "hobby" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Hobby,
                "pro" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}