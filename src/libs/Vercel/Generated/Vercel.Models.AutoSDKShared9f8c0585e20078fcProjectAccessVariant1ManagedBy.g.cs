
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy
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
    public static class AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy.Drain => "drain",
                AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy.Drain,
                "integration" => AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy.Integration,
                _ => null,
            };
        }
    }
}