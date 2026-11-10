
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntime value)
        {
            return value switch
            {
                AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => AutoSDKSharedcdaac4bd3d3c6643MiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}