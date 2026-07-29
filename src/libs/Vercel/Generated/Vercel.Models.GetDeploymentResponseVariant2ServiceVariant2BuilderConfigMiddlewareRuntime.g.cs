
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => GetDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}