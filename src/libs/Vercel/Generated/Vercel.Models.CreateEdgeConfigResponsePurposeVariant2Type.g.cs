
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEdgeConfigResponsePurposeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEdgeConfigResponsePurposeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEdgeConfigResponsePurposeVariant2Type value)
        {
            return value switch
            {
                CreateEdgeConfigResponsePurposeVariant2Type.Experimentation => "experimentation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEdgeConfigResponsePurposeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => CreateEdgeConfigResponsePurposeVariant2Type.Experimentation,
                _ => null,
            };
        }
    }
}