
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1TransformOp
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
    public static class CreateDeploymentResponseRouteVariant1TransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1TransformOp value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1TransformOp.Append => "append",
                CreateDeploymentResponseRouteVariant1TransformOp.Delete => "delete",
                CreateDeploymentResponseRouteVariant1TransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1TransformOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => CreateDeploymentResponseRouteVariant1TransformOp.Append,
                "delete" => CreateDeploymentResponseRouteVariant1TransformOp.Delete,
                "set" => CreateDeploymentResponseRouteVariant1TransformOp.Set,
                _ => null,
            };
        }
    }
}