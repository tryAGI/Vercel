
#nullable enable

namespace Vercel
{
    /// <summary>
    /// One of `HIT` or `MISS`. `HIT` specifies that a cached artifact for `hash` was found in the cache. `MISS` specifies that a cached artifact with `hash` was not found.
    /// </summary>
    public enum RecordEventsRequestItemEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Hit,
        /// <summary>
        /// 
        /// </summary>
        Miss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordEventsRequestItemEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordEventsRequestItemEvent value)
        {
            return value switch
            {
                RecordEventsRequestItemEvent.Hit => "HIT",
                RecordEventsRequestItemEvent.Miss => "MISS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordEventsRequestItemEvent? ToEnum(string value)
        {
            return value switch
            {
                "HIT" => RecordEventsRequestItemEvent.Hit,
                "MISS" => RecordEventsRequestItemEvent.Miss,
                _ => null,
            };
        }
    }
}