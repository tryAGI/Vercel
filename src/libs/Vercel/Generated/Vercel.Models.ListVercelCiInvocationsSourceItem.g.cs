
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVercelCiInvocationsSourceItem
    {
        /// <summary>
        ///
        /// </summary>
        VercelCi,
        /// <summary>
        ///
        /// </summary>
        VercelNativeChecks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVercelCiInvocationsSourceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVercelCiInvocationsSourceItem value)
        {
            return value switch
            {
                ListVercelCiInvocationsSourceItem.VercelCi => "vercel-ci",
                ListVercelCiInvocationsSourceItem.VercelNativeChecks => "vercel-native-checks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVercelCiInvocationsSourceItem? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci" => ListVercelCiInvocationsSourceItem.VercelCi,
                "vercel-native-checks" => ListVercelCiInvocationsSourceItem.VercelNativeChecks,
                _ => null,
            };
        }
    }
}