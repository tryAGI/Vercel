
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy
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
    public static class AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy.Drain => "drain",
                AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy.Drain,
                "integration" => AutoSDKSharedd5d6c9ab94c25f66ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}