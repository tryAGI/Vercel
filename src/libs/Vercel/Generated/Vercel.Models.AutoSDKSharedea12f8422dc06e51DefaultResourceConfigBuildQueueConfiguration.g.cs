
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}