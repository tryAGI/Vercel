
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}