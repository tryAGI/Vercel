
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16Requires
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
    public static class AutoSDKSharedca611ecff4bbfd16RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16Requires value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16Requires.BuildReady => "build-ready",
                AutoSDKSharedca611ecff4bbfd16Requires.DeploymentUrl => "deployment-url",
                AutoSDKSharedca611ecff4bbfd16Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKSharedca611ecff4bbfd16Requires.BuildReady,
                "deployment-url" => AutoSDKSharedca611ecff4bbfd16Requires.DeploymentUrl,
                "none" => AutoSDKSharedca611ecff4bbfd16Requires.None,
                _ => null,
            };
        }
    }
}