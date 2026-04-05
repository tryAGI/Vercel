
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEdgeConfigResponsePurposeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEdgeConfigResponsePurposeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEdgeConfigResponsePurposeVariant1Type value)
        {
            return value switch
            {
                GetEdgeConfigResponsePurposeVariant1Type.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEdgeConfigResponsePurposeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "flags" => GetEdgeConfigResponsePurposeVariant1Type.Flags,
                _ => null,
            };
        }
    }
}