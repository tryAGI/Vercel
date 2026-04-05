
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEdgeConfigResponsePurposeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEdgeConfigResponsePurposeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEdgeConfigResponsePurposeVariant1Type value)
        {
            return value switch
            {
                CreateEdgeConfigResponsePurposeVariant1Type.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEdgeConfigResponsePurposeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "flags" => CreateEdgeConfigResponsePurposeVariant1Type.Flags,
                _ => null,
            };
        }
    }
}