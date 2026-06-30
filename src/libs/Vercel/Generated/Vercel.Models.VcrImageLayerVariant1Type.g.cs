
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcrImageLayerVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        From,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant1Type value)
        {
            return value switch
            {
                VcrImageLayerVariant1Type.From => "FROM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "FROM" => VcrImageLayerVariant1Type.From,
                _ => null,
            };
        }
    }
}