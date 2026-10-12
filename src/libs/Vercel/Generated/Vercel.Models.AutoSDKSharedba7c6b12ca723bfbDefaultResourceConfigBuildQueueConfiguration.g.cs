
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration
    {
        /// <summary>
        ///
        /// </summary>
        SkipNamespaceQueue,
        /// <summary>
        ///
        /// </summary>
        WaitForNamespaceQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => AutoSDKSharedba7c6b12ca723bfbDefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}