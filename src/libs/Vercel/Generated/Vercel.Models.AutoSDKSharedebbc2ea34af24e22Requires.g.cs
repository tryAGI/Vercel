
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22Requires
    {
        /// <summary>
        ///
        /// </summary>
        BuildReady,
        /// <summary>
        ///
        /// </summary>
        DeploymentUrl,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22Requires value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22Requires.BuildReady => "build-ready",
                AutoSDKSharedebbc2ea34af24e22Requires.DeploymentUrl => "deployment-url",
                AutoSDKSharedebbc2ea34af24e22Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKSharedebbc2ea34af24e22Requires.BuildReady,
                "deployment-url" => AutoSDKSharedebbc2ea34af24e22Requires.DeploymentUrl,
                "none" => AutoSDKSharedebbc2ea34af24e22Requires.None,
                _ => null,
            };
        }
    }
}