
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}