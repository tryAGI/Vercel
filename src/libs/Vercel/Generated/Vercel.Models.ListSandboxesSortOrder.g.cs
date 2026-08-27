
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction. Defaults to desc.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListSandboxesSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSandboxesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSandboxesSortOrder value)
        {
            return value switch
            {
                ListSandboxesSortOrder.Asc => "asc",
                ListSandboxesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSandboxesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSandboxesSortOrder.Asc,
                "desc" => ListSandboxesSortOrder.Desc,
                _ => null,
            };
        }
    }
}