
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponsePlan
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
    public static class CancelDeploymentResponsePlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponsePlan value)
        {
            return value switch
            {
                CancelDeploymentResponsePlan.Enterprise => "enterprise",
                CancelDeploymentResponsePlan.Hobby => "hobby",
                CancelDeploymentResponsePlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponsePlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CancelDeploymentResponsePlan.Enterprise,
                "hobby" => CancelDeploymentResponsePlan.Hobby,
                "pro" => CancelDeploymentResponsePlan.Pro,
                _ => null,
            };
        }
    }
}