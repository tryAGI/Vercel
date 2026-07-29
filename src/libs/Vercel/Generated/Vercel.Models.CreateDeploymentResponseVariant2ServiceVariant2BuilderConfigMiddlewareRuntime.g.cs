
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => CreateDeploymentResponseVariant2ServiceVariant2BuilderConfigMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}