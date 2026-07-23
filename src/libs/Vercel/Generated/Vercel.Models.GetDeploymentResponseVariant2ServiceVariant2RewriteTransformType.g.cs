
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2RewriteTransformType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2RewriteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2RewriteTransformType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2RewriteTransformType.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2RewriteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => GetDeploymentResponseVariant2ServiceVariant2RewriteTransformType.RequestPath,
                _ => null,
            };
        }
    }
}