
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared37c775f169729655ResourcesRequestsMemory
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
    public static class AutoSDKShared37c775f169729655ResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared37c775f169729655ResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKShared37c775f169729655ResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKShared37c775f169729655ResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKShared37c775f169729655ResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKShared37c775f169729655ResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared37c775f169729655ResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKShared37c775f169729655ResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKShared37c775f169729655ResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKShared37c775f169729655ResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKShared37c775f169729655ResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}