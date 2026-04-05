
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectUsageStatusKind
    {
        /// <summary>
        /// 
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectUsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectUsageStatusKind value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectUsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectUsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => GetMicrofrontendsInGroupResponseProjectUsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}