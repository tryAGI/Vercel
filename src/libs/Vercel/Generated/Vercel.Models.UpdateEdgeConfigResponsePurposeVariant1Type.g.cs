
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateEdgeConfigResponsePurposeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEdgeConfigResponsePurposeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEdgeConfigResponsePurposeVariant1Type value)
        {
            return value switch
            {
                UpdateEdgeConfigResponsePurposeVariant1Type.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEdgeConfigResponsePurposeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "flags" => UpdateEdgeConfigResponsePurposeVariant1Type.Flags,
                _ => null,
            };
        }
    }
}