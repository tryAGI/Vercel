
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKShared39497871754bda72UsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared39497871754bda72UsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72UsageStatusKind value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72UsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72UsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKShared39497871754bda72UsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}