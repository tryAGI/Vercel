
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3Requires
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
    public static class AutoSDKShared87d88207314b07b3RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3Requires value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3Requires.BuildReady => "build-ready",
                AutoSDKShared87d88207314b07b3Requires.DeploymentUrl => "deployment-url",
                AutoSDKShared87d88207314b07b3Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared87d88207314b07b3Requires.BuildReady,
                "deployment-url" => AutoSDKShared87d88207314b07b3Requires.DeploymentUrl,
                "none" => AutoSDKShared87d88207314b07b3Requires.None,
                _ => null,
            };
        }
    }
}