
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory
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
    public static class AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKSharede00733f58a3cbcc8DaemonResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}