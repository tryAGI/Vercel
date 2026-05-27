
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum ListSandboxesSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        CurrentSnapshotId,
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
    public static class ListSandboxesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSandboxesSortBy value)
        {
            return value switch
            {
                ListSandboxesSortBy.CreatedAt => "createdAt",
                ListSandboxesSortBy.CurrentSnapshotId => "currentSnapshotId",
                ListSandboxesSortBy.Name => "name",
                ListSandboxesSortBy.StatusUpdatedAt => "statusUpdatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSandboxesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListSandboxesSortBy.CreatedAt,
                "currentSnapshotId" => ListSandboxesSortBy.CurrentSnapshotId,
                "name" => ListSandboxesSortBy.Name,
                "statusUpdatedAt" => ListSandboxesSortBy.StatusUpdatedAt,
                _ => null,
            };
        }
    }
}