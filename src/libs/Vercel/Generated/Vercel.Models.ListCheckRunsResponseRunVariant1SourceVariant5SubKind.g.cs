
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1SourceVariant5SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunVariant1SourceVariant5SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1SourceVariant5SubKind value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1SourceVariant5SubKind.VercelCiCheck => "vercel-ci-check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1SourceVariant5SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-check" => ListCheckRunsResponseRunVariant1SourceVariant5SubKind.VercelCiCheck,
                _ => null,
            };
        }
    }
}