
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2Plan
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
    public static class GetDeploymentResponseVariant2PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2Plan value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2Plan.Enterprise => "enterprise",
                GetDeploymentResponseVariant2Plan.Hobby => "hobby",
                GetDeploymentResponseVariant2Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetDeploymentResponseVariant2Plan.Enterprise,
                "hobby" => GetDeploymentResponseVariant2Plan.Hobby,
                "pro" => GetDeploymentResponseVariant2Plan.Pro,
                _ => null,
            };
        }
    }
}