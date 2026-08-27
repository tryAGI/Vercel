
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2SourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant2SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2SourceVariant2Origin value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => ListCheckRunsResponseRunVariant2SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}