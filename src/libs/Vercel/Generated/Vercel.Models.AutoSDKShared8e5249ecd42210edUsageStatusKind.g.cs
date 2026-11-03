
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edUsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8e5249ecd42210edUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edUsageStatusKind value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKShared8e5249ecd42210edUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}