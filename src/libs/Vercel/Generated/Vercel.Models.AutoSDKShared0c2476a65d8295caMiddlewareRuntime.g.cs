
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum AutoSDKShared0c2476a65d8295caMiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0c2476a65d8295caMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0c2476a65d8295caMiddlewareRuntime value)
        {
            return value switch
            {
                AutoSDKShared0c2476a65d8295caMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0c2476a65d8295caMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => AutoSDKShared0c2476a65d8295caMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}