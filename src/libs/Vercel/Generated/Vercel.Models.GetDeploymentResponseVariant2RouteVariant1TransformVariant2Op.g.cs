
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2RouteVariant1TransformVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2RouteVariant1TransformVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2RouteVariant1TransformVariant2Op value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2RouteVariant1TransformVariant2Op.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2RouteVariant1TransformVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "set" => GetDeploymentResponseVariant2RouteVariant1TransformVariant2Op.Set,
                _ => null,
            };
        }
    }
}