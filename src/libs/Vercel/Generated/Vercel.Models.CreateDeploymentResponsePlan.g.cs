
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponsePlan
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
    public static class CreateDeploymentResponsePlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponsePlan value)
        {
            return value switch
            {
                CreateDeploymentResponsePlan.Enterprise => "enterprise",
                CreateDeploymentResponsePlan.Hobby => "hobby",
                CreateDeploymentResponsePlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponsePlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CreateDeploymentResponsePlan.Enterprise,
                "hobby" => CreateDeploymentResponsePlan.Hobby,
                "pro" => CreateDeploymentResponsePlan.Pro,
                _ => null,
            };
        }
    }
}