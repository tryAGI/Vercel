
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum AutoSDKShared922c97954e29e8b6MiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared922c97954e29e8b6MiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared922c97954e29e8b6MiddlewareRuntime value)
        {
            return value switch
            {
                AutoSDKShared922c97954e29e8b6MiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared922c97954e29e8b6MiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => AutoSDKShared922c97954e29e8b6MiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}