
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy
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
    public static class AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy.Drain => "drain",
                AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy.Drain,
                "integration" => AutoSDKShared2bfc0b0e9e85f636ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}