
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEdgeConfigResponsePurposeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEdgeConfigResponsePurposeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEdgeConfigResponsePurposeVariant2Type value)
        {
            return value switch
            {
                GetEdgeConfigResponsePurposeVariant2Type.Experimentation => "experimentation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEdgeConfigResponsePurposeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => GetEdgeConfigResponsePurposeVariant2Type.Experimentation,
                _ => null,
            };
        }
    }
}