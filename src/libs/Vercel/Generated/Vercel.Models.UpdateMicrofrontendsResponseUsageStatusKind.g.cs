
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum UpdateMicrofrontendsResponseUsageStatusKind
    {
        /// <summary>
        /// 
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseUsageStatusKind value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => UpdateMicrofrontendsResponseUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}