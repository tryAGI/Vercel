
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2RewriteTransformOp
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2RewriteTransformOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2RewriteTransformOp value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2RewriteTransformOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2RewriteTransformOp? ToEnum(string value)
        {
            return value switch
            {
                "set" => CreateDeploymentResponseServiceVariant2RewriteTransformOp.Set,
                _ => null,
            };
        }
    }
}