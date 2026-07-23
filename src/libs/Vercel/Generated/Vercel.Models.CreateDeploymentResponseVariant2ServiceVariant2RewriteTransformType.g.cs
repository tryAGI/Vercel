
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformType.RequestPath => "request.path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.path" => CreateDeploymentResponseVariant2ServiceVariant2RewriteTransformType.RequestPath,
                _ => null,
            };
        }
    }
}