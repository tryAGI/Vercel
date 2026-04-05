
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateEdgeConfigResponsePurposeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEdgeConfigResponsePurposeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEdgeConfigResponsePurposeVariant2Type value)
        {
            return value switch
            {
                UpdateEdgeConfigResponsePurposeVariant2Type.Experimentation => "experimentation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEdgeConfigResponsePurposeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => UpdateEdgeConfigResponsePurposeVariant2Type.Experimentation,
                _ => null,
            };
        }
    }
}