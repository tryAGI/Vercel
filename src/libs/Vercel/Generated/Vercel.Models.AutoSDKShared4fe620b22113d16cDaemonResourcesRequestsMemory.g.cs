
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory
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
    public static class AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}