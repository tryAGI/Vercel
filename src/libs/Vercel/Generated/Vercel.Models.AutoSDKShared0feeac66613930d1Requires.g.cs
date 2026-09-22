
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1Requires
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
    public static class AutoSDKShared0feeac66613930d1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1Requires value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1Requires.BuildReady => "build-ready",
                AutoSDKShared0feeac66613930d1Requires.DeploymentUrl => "deployment-url",
                AutoSDKShared0feeac66613930d1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared0feeac66613930d1Requires.BuildReady,
                "deployment-url" => AutoSDKShared0feeac66613930d1Requires.DeploymentUrl,
                "none" => AutoSDKShared0feeac66613930d1Requires.None,
                _ => null,
            };
        }
    }
}