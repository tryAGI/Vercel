
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy.Drain => "drain",
                GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy.Drain,
                "integration" => GetAllLogDrainsResponseDrainsVariant2ItemProjectAccessVariant1ManagedBy.Integration,
                _ => null,
            };
        }
    }
}