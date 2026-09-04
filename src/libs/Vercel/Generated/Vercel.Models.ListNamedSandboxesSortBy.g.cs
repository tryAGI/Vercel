
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum ListNamedSandboxesSortBy
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
    public static class ListNamedSandboxesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListNamedSandboxesSortBy value)
        {
            return value switch
            {
                ListNamedSandboxesSortBy.CreatedAt => "createdAt",
                ListNamedSandboxesSortBy.CurrentSnapshotId => "currentSnapshotId",
                ListNamedSandboxesSortBy.Name => "name",
                ListNamedSandboxesSortBy.StatusUpdatedAt => "statusUpdatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListNamedSandboxesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListNamedSandboxesSortBy.CreatedAt,
                "currentSnapshotId" => ListNamedSandboxesSortBy.CurrentSnapshotId,
                "name" => ListNamedSandboxesSortBy.Name,
                "statusUpdatedAt" => ListNamedSandboxesSortBy.StatusUpdatedAt,
                _ => null,
            };
        }
    }
}