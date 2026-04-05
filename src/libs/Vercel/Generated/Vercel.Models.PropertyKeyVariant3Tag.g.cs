
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PropertyKeyVariant3Tag
    {
        /// <summary>
        /// 
        /// </summary>
        Symbol,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertyKeyVariant3TagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertyKeyVariant3Tag value)
        {
            return value switch
            {
                PropertyKeyVariant3Tag.Symbol => "symbol",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertyKeyVariant3Tag? ToEnum(string value)
        {
            return value switch
            {
                "symbol" => PropertyKeyVariant3Tag.Symbol,
                _ => null,
            };
        }
    }
}