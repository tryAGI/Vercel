
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEdgeConfigsResponsePurposeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEdgeConfigsResponsePurposeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEdgeConfigsResponsePurposeVariant2Type value)
        {
            return value switch
            {
                GetEdgeConfigsResponsePurposeVariant2Type.Experimentation => "experimentation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEdgeConfigsResponsePurposeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => GetEdgeConfigsResponsePurposeVariant2Type.Experimentation,
                _ => null,
            };
        }
    }
}