
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration
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
    public static class AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}