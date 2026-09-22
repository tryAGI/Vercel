
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy
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
    public static class AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy.Drain => "drain",
                AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy.Drain,
                "integration" => AutoSDKShared383028c008cc4ae0ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}