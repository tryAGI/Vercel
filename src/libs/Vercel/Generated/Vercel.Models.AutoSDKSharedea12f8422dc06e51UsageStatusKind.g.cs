
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51UsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedea12f8422dc06e51UsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51UsageStatusKind value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51UsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51UsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKSharedea12f8422dc06e51UsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}