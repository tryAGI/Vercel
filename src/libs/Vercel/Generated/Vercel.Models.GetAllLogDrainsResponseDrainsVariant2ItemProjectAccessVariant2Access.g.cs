
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access
    {
        /// <summary>
        /// 
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}