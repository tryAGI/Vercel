
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum GetProjectResponseUsageStatusKind
    {
        /// <summary>
        /// 
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseUsageStatusKind value)
        {
            return value switch
            {
                GetProjectResponseUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => GetProjectResponseUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}