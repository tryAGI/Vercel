
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEdgeConfigsResponsePurposeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEdgeConfigsResponsePurposeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEdgeConfigsResponsePurposeVariant1Type value)
        {
            return value switch
            {
                GetEdgeConfigsResponsePurposeVariant1Type.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEdgeConfigsResponsePurposeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "flags" => GetEdgeConfigsResponsePurposeVariant1Type.Flags,
                _ => null,
            };
        }
    }
}