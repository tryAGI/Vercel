
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOp
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOp value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "set" => GetDeploymentResponseVariant1ServiceVariant2RewriteTransformOp.Set,
                _ => null,
            };
        }
    }
}