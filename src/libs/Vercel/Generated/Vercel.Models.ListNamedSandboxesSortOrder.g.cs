
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction. Defaults to desc.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListNamedSandboxesSortOrder
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
    public static class ListNamedSandboxesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListNamedSandboxesSortOrder value)
        {
            return value switch
            {
                ListNamedSandboxesSortOrder.Asc => "asc",
                ListNamedSandboxesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListNamedSandboxesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListNamedSandboxesSortOrder.Asc,
                "desc" => ListNamedSandboxesSortOrder.Desc,
                _ => null,
            };
        }
    }
}