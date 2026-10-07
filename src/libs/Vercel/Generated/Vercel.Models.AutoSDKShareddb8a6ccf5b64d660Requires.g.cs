
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660Requires
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
    public static class AutoSDKShareddb8a6ccf5b64d660RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660Requires value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660Requires.BuildReady => "build-ready",
                AutoSDKShareddb8a6ccf5b64d660Requires.DeploymentUrl => "deployment-url",
                AutoSDKShareddb8a6ccf5b64d660Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShareddb8a6ccf5b64d660Requires.BuildReady,
                "deployment-url" => AutoSDKShareddb8a6ccf5b64d660Requires.DeploymentUrl,
                "none" => AutoSDKShareddb8a6ccf5b64d660Requires.None,
                _ => null,
            };
        }
    }
}