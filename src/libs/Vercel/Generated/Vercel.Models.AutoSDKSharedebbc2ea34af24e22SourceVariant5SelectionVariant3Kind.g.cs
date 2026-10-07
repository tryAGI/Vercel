
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3Kind value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3Kind.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "job" => AutoSDKSharedebbc2ea34af24e22SourceVariant5SelectionVariant3Kind.Job,
                _ => null,
            };
        }
    }
}