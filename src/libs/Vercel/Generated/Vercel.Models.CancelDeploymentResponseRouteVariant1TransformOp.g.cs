
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1TransformOp
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
    public static class CancelDeploymentResponseRouteVariant1TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1TransformOp value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1TransformOp.Append => "append",
                CancelDeploymentResponseRouteVariant1TransformOp.Delete => "delete",
                CancelDeploymentResponseRouteVariant1TransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => CancelDeploymentResponseRouteVariant1TransformOp.Append,
                "delete" => CancelDeploymentResponseRouteVariant1TransformOp.Delete,
                "set" => CancelDeploymentResponseRouteVariant1TransformOp.Set,
                _ => null,
            };
        }
    }
}