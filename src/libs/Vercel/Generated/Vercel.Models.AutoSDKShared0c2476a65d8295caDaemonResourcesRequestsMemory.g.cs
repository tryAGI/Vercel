
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory
    {
        /// <summary>
        ///
        /// </summary>
        x1Gi,
        /// <summary>
        ///
        /// </summary>
        x2Gi,
        /// <summary>
        ///
        /// </summary>
        x4Gi,
        /// <summary>
        ///
        /// </summary>
        x8Gi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}