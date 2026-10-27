
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20UsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429ed81b15078f20UsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20UsageStatusKind value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20UsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20UsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKShared429ed81b15078f20UsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}