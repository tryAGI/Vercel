
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enforced runtime for explicitly configured Routing Middleware.
    /// </summary>
    public enum AutoSDKSharede816b13e35b68c5aMiddlewareRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Nodejs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede816b13e35b68c5aMiddlewareRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede816b13e35b68c5aMiddlewareRuntime value)
        {
            return value switch
            {
                AutoSDKSharede816b13e35b68c5aMiddlewareRuntime.Nodejs => "nodejs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede816b13e35b68c5aMiddlewareRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs" => AutoSDKSharede816b13e35b68c5aMiddlewareRuntime.Nodejs,
                _ => null,
            };
        }
    }
}