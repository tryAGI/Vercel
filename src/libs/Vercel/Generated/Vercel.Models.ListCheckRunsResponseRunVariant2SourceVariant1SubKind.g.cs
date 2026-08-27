
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2SourceVariant1SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant2SourceVariant1SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2SourceVariant1SubKind value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2SourceVariant1SubKind.VercelCi => "vercel-ci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2SourceVariant1SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci" => ListCheckRunsResponseRunVariant2SourceVariant1SubKind.VercelCi,
                _ => null,
            };
        }
    }
}