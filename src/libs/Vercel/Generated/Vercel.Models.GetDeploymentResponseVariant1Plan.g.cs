
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1Plan
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
    public static class GetDeploymentResponseVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1Plan value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1Plan.Enterprise => "enterprise",
                GetDeploymentResponseVariant1Plan.Hobby => "hobby",
                GetDeploymentResponseVariant1Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => GetDeploymentResponseVariant1Plan.Enterprise,
                "hobby" => GetDeploymentResponseVariant1Plan.Hobby,
                "pro" => GetDeploymentResponseVariant1Plan.Pro,
                _ => null,
            };
        }
    }
}