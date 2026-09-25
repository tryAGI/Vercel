
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVercelCiInvocationsConclusionItem
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVercelCiInvocationsConclusionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVercelCiInvocationsConclusionItem value)
        {
            return value switch
            {
                ListVercelCiInvocationsConclusionItem.Failed => "failed",
                ListVercelCiInvocationsConclusionItem.Skipped => "skipped",
                ListVercelCiInvocationsConclusionItem.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVercelCiInvocationsConclusionItem? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ListVercelCiInvocationsConclusionItem.Failed,
                "skipped" => ListVercelCiInvocationsConclusionItem.Skipped,
                "succeeded" => ListVercelCiInvocationsConclusionItem.Succeeded,
                _ => null,
            };
        }
    }
}