
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction. Defaults to desc.<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSandboxesV2SortOrder
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
    public static class GetSandboxesV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesV2SortOrder value)
        {
            return value switch
            {
                GetSandboxesV2SortOrder.Asc => "asc",
                GetSandboxesV2SortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSandboxesV2SortOrder.Asc,
                "desc" => GetSandboxesV2SortOrder.Desc,
                _ => null,
            };
        }
    }
}