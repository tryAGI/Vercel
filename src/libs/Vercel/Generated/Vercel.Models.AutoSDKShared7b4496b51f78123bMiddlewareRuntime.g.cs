
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum AutoSDKShared7b4496b51f78123bMiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7b4496b51f78123bMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7b4496b51f78123bMiddlewareRuntime value)
        {
            return value switch
            {
                AutoSDKShared7b4496b51f78123bMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7b4496b51f78123bMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => AutoSDKShared7b4496b51f78123bMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}