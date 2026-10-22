
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy
    {
        /// <summary>
        ///
        /// </summary>
        Drain,
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy.Drain => "drain",
                AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy.Drain,
                "integration" => AutoSDKShared6df91f8a45eab833ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}