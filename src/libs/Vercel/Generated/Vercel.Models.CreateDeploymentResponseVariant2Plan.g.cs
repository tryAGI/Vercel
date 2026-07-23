
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2Plan
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
    public static class CreateDeploymentResponseVariant2PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2Plan value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2Plan.Enterprise => "enterprise",
                CreateDeploymentResponseVariant2Plan.Hobby => "hobby",
                CreateDeploymentResponseVariant2Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CreateDeploymentResponseVariant2Plan.Enterprise,
                "hobby" => CreateDeploymentResponseVariant2Plan.Hobby,
                "pro" => CreateDeploymentResponseVariant2Plan.Pro,
                _ => null,
            };
        }
    }
}