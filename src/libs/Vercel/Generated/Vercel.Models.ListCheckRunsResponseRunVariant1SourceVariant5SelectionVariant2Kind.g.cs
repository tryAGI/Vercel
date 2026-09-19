
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2Kind value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2Kind.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "job" => ListCheckRunsResponseRunVariant1SourceVariant5SelectionVariant2Kind.Job,
                _ => null,
            };
        }
    }
}