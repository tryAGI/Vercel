
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy
    {
        /// <summary>
        /// 
        /// </summary>
        Drain,
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy.Drain => "drain",
                GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy.Drain,
                "integration" => GetDrainsResponseDrainsVariant2ItemProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}