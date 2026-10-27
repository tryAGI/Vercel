
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory
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
    public static class AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory value)
        {
            return value switch
            {
                AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x1Gi => "1Gi",
                AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x2Gi => "2Gi",
                AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x4Gi => "4Gi",
                AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x8Gi => "8Gi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory? ToEnum(string value)
        {
            return value switch
            {
                "1Gi" => AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x1Gi,
                "2Gi" => AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x2Gi,
                "4Gi" => AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x4Gi,
                "8Gi" => AutoSDKSharedb4706d78b2b82e72ResourcesRequestsMemory.x8Gi,
                _ => null,
            };
        }
    }
}