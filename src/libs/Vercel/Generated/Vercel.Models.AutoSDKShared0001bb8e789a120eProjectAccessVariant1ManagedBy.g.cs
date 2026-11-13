
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy
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
    public static class AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy.Drain => "drain",
                AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy.Drain,
                "integration" => AutoSDKShared0001bb8e789a120eProjectAccessVariant1ManagedBy.Integration,
                _ => null,
            };
        }
    }
}