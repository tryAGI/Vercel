
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2Kind.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "job" => AutoSDKShared0feeac66613930d1SourceVariant5SelectionVariant2Kind.Job,
                _ => null,
            };
        }
    }
}