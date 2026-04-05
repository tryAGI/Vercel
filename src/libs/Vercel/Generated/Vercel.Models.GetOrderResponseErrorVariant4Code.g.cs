
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant4Code
    {
        /// <summary>
        /// 
        /// </summary>
        UnexpectedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant4CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant4Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant4Code.UnexpectedError => "unexpected-error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant4Code? ToEnum(string value)
        {
            return value switch
            {
                "unexpected-error" => GetOrderResponseErrorVariant4Code.UnexpectedError,
                _ => null,
            };
        }
    }
}