
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1RouteVariant1TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Append => "append",
                GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Delete => "delete",
                GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Append,
                "delete" => GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Delete,
                "set" => GetDeploymentResponseVariant1RouteVariant1TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}