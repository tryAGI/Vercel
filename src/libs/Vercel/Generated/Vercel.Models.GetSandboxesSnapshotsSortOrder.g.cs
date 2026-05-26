
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results by creation time.<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSandboxesSnapshotsSortOrder
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
    public static class GetSandboxesSnapshotsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSnapshotsSortOrder value)
        {
            return value switch
            {
                GetSandboxesSnapshotsSortOrder.Asc => "asc",
                GetSandboxesSnapshotsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSnapshotsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSandboxesSnapshotsSortOrder.Asc,
                "desc" => GetSandboxesSnapshotsSortOrder.Desc,
                _ => null,
            };
        }
    }
}