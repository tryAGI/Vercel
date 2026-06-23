
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1TransformVariant1Op
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
    public static class CreateDeploymentResponseRouteVariant1TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1TransformVariant1Op value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1TransformVariant1Op.Append => "append",
                CreateDeploymentResponseRouteVariant1TransformVariant1Op.Delete => "delete",
                CreateDeploymentResponseRouteVariant1TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => CreateDeploymentResponseRouteVariant1TransformVariant1Op.Append,
                "delete" => CreateDeploymentResponseRouteVariant1TransformVariant1Op.Delete,
                "set" => CreateDeploymentResponseRouteVariant1TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}