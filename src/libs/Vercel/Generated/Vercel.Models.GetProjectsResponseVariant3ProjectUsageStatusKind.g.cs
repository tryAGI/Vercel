
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectUsageStatusKind
    {
        /// <summary>
        /// 
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectUsageStatusKind value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => GetProjectsResponseVariant3ProjectUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}