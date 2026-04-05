
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum UpdateProjectResponseUsageStatusKind
    {
        /// <summary>
        /// 
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseUsageStatusKind value)
        {
            return value switch
            {
                UpdateProjectResponseUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => UpdateProjectResponseUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}