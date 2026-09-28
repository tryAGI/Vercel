
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fUsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda223f19b9c37327fUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fUsageStatusKind value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKShareda223f19b9c37327fUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}