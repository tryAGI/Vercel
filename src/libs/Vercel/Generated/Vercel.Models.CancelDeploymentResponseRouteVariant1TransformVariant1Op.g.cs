
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1TransformVariant1Op
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
    public static class CancelDeploymentResponseRouteVariant1TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1TransformVariant1Op value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1TransformVariant1Op.Append => "append",
                CancelDeploymentResponseRouteVariant1TransformVariant1Op.Delete => "delete",
                CancelDeploymentResponseRouteVariant1TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => CancelDeploymentResponseRouteVariant1TransformVariant1Op.Append,
                "delete" => CancelDeploymentResponseRouteVariant1TransformVariant1Op.Delete,
                "set" => CancelDeploymentResponseRouteVariant1TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}