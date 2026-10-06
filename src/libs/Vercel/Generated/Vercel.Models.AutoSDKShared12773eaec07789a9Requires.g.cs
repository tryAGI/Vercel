
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9Requires
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
    public static class AutoSDKShared12773eaec07789a9RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9Requires value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9Requires.BuildReady => "build-ready",
                AutoSDKShared12773eaec07789a9Requires.DeploymentUrl => "deployment-url",
                AutoSDKShared12773eaec07789a9Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => AutoSDKShared12773eaec07789a9Requires.BuildReady,
                "deployment-url" => AutoSDKShared12773eaec07789a9Requires.DeploymentUrl,
                "none" => AutoSDKShared12773eaec07789a9Requires.None,
                _ => null,
            };
        }
    }
}