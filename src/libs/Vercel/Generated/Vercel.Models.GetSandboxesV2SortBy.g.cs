
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum GetSandboxesV2SortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        StatusUpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSandboxesV2SortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesV2SortBy value)
        {
            return value switch
            {
                GetSandboxesV2SortBy.CreatedAt => "createdAt",
                GetSandboxesV2SortBy.Name => "name",
                GetSandboxesV2SortBy.StatusUpdatedAt => "statusUpdatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesV2SortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GetSandboxesV2SortBy.CreatedAt,
                "name" => GetSandboxesV2SortBy.Name,
                "statusUpdatedAt" => GetSandboxesV2SortBy.StatusUpdatedAt,
                _ => null,
            };
        }
    }
}