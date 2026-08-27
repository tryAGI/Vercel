
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntime value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => CancelDeploymentResponseServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}