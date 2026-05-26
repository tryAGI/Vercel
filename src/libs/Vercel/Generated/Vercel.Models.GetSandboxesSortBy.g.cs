
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum GetSandboxesSortBy
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
    public static class GetSandboxesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSortBy value)
        {
            return value switch
            {
                GetSandboxesSortBy.CreatedAt => "createdAt",
                GetSandboxesSortBy.CurrentSnapshotId => "currentSnapshotId",
                GetSandboxesSortBy.Name => "name",
                GetSandboxesSortBy.StatusUpdatedAt => "statusUpdatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GetSandboxesSortBy.CreatedAt,
                "currentSnapshotId" => GetSandboxesSortBy.CurrentSnapshotId,
                "name" => GetSandboxesSortBy.Name,
                "statusUpdatedAt" => GetSandboxesSortBy.StatusUpdatedAt,
                _ => null,
            };
        }
    }
}