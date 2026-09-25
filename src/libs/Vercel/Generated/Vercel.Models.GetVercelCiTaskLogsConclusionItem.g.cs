
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiTaskLogsConclusionItem
    {
        /// <summary>
        ///
        /// </summary>
        Cached,
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
    public static class GetVercelCiTaskLogsConclusionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiTaskLogsConclusionItem value)
        {
            return value switch
            {
                GetVercelCiTaskLogsConclusionItem.Cached => "cached",
                GetVercelCiTaskLogsConclusionItem.Failed => "failed",
                GetVercelCiTaskLogsConclusionItem.Skipped => "skipped",
                GetVercelCiTaskLogsConclusionItem.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiTaskLogsConclusionItem? ToEnum(string value)
        {
            return value switch
            {
                "cached" => GetVercelCiTaskLogsConclusionItem.Cached,
                "failed" => GetVercelCiTaskLogsConclusionItem.Failed,
                "skipped" => GetVercelCiTaskLogsConclusionItem.Skipped,
                "succeeded" => GetVercelCiTaskLogsConclusionItem.Succeeded,
                _ => null,
            };
        }
    }
}