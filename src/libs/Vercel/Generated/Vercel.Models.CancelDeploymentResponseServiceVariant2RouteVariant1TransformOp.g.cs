
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp
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
    public static class CancelDeploymentResponseServiceVariant2RouteVariant1TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Append => "append",
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Delete => "delete",
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Append,
                "delete" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Delete,
                "set" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformOp.Set,
                _ => null,
            };
        }
    }
}