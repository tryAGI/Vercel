
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}