
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1TransformVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseRouteVariant1TransformVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1TransformVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1TransformVariant2Type.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1TransformVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => CreateDeploymentResponseRouteVariant1TransformVariant2Type.RequestPath,
                _ => null,
            };
        }
    }
}