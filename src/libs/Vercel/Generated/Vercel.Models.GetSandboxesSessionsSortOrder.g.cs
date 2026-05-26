
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results by creation time.<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSandboxesSessionsSortOrder
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
    public static class GetSandboxesSessionsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSessionsSortOrder value)
        {
            return value switch
            {
                GetSandboxesSessionsSortOrder.Asc => "asc",
                GetSandboxesSessionsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSessionsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSandboxesSessionsSortOrder.Asc,
                "desc" => GetSandboxesSessionsSortOrder.Desc,
                _ => null,
            };
        }
    }
}