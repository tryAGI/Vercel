
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2Op
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2Op value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1TransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}