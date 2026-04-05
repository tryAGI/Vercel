
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemSourceVariant2Kind value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetDrainsResponseDrainsVariant1ItemSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}