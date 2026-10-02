
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329Requires
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
    public static class AutoSDKShared5455d199d07ea329RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329Requires value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329Requires.BuildReady => "build-ready",
                AutoSDKShared5455d199d07ea329Requires.DeploymentUrl => "deployment-url",
                AutoSDKShared5455d199d07ea329Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared5455d199d07ea329Requires.BuildReady,
                "deployment-url" => AutoSDKShared5455d199d07ea329Requires.DeploymentUrl,
                "none" => AutoSDKShared5455d199d07ea329Requires.None,
                _ => null,
            };
        }
    }
}