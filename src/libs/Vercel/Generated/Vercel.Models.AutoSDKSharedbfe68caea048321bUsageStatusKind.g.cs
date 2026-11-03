
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bUsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbfe68caea048321bUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bUsageStatusKind value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKSharedbfe68caea048321bUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}