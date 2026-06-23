
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant2RewriteTransformType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant2RewriteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant2RewriteTransformType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant2RewriteTransformType.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant2RewriteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => GetDeploymentResponseVariant1ServiceVariant2RewriteTransformType.RequestPath,
                _ => null,
            };
        }
    }
}