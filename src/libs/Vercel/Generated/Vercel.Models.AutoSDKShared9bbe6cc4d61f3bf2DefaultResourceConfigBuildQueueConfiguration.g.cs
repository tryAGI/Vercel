
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}