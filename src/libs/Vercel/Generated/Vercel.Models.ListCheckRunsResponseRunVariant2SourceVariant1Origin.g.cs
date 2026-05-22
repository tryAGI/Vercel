
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2SourceVariant1Origin
    {
        /// <summary>
        /// 
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant2SourceVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2SourceVariant1Origin value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2SourceVariant1Origin.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2SourceVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "config" => ListCheckRunsResponseRunVariant2SourceVariant1Origin.Config,
                _ => null,
            };
        }
    }
}