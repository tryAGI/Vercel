
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op
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
    public static class CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Append => "append",
                CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Delete => "delete",
                CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "append" => CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Append,
                "delete" => CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Delete,
                "set" => CreateDeploymentResponseServiceVariant2RouteVariant1TransformVariant1Op.Set,
                _ => null,
            };
        }
    }
}