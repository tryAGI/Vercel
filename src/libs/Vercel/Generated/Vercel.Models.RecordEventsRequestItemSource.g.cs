
#nullable enable

namespace Vercel
{
    /// <summary>
    /// One of `LOCAL` or `REMOTE`. `LOCAL` specifies that the cache event was from the user's filesystem cache. `REMOTE` specifies that the cache event is from a remote cache.
    /// </summary>
    public enum RecordEventsRequestItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Remote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordEventsRequestItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordEventsRequestItemSource value)
        {
            return value switch
            {
                RecordEventsRequestItemSource.Local => "LOCAL",
                RecordEventsRequestItemSource.Remote => "REMOTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordEventsRequestItemSource? ToEnum(string value)
        {
            return value switch
            {
                "LOCAL" => RecordEventsRequestItemSource.Local,
                "REMOTE" => RecordEventsRequestItemSource.Remote,
                _ => null,
            };
        }
    }
}