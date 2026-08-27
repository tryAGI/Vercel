
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntime value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => CancelDeploymentResponseServiceVariant1BuilderConfigMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}