
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1TransformOp
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
    public static class GetDeploymentResponseVariant1RouteVariant1TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1TransformOp value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1TransformOp.Append => "append",
                GetDeploymentResponseVariant1RouteVariant1TransformOp.Delete => "delete",
                GetDeploymentResponseVariant1RouteVariant1TransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GetDeploymentResponseVariant1RouteVariant1TransformOp.Append,
                "delete" => GetDeploymentResponseVariant1RouteVariant1TransformOp.Delete,
                "set" => GetDeploymentResponseVariant1RouteVariant1TransformOp.Set,
                _ => null,
            };
        }
    }
}