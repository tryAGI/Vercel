
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction. Defaults to desc.<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSandboxesSortOrder
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
    public static class GetSandboxesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSortOrder value)
        {
            return value switch
            {
                GetSandboxesSortOrder.Asc => "asc",
                GetSandboxesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSandboxesSortOrder.Asc,
                "desc" => GetSandboxesSortOrder.Desc,
                _ => null,
            };
        }
    }
}