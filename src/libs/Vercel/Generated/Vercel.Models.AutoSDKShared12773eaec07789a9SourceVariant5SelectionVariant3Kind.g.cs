
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Job,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3Kind value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3Kind.Job => "job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "job" => AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3Kind.Job,
                _ => null,
            };
        }
    }
}