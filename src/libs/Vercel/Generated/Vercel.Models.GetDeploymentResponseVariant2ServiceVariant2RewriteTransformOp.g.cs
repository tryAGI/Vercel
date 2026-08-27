
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOp
    {
        /// <summary>
        ///
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOp value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "set" => GetDeploymentResponseVariant2ServiceVariant2RewriteTransformOp.Set,
                _ => null,
            };
        }
    }
}