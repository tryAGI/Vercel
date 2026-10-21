
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory
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
    public static class AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}