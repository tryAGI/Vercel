
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1Kind value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}