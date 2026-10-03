
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration
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
    public static class AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfigurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration.SkipNamespaceQueue => "SKIP_NAMESPACE_QUEUE",
                AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue => "WAIT_FOR_NAMESPACE_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration? ToEnum(string value)
        {
            return value switch
            {
                "SKIP_NAMESPACE_QUEUE" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration.SkipNamespaceQueue,
                "WAIT_FOR_NAMESPACE_QUEUE" => AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration.WaitForNamespaceQueue,
                _ => null,
            };
        }
    }
}