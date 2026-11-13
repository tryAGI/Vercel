
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the alias has been mapped to the deployment targeted by the last request. `pending` is also returned when the project has no request of the requested type, so it does not by itself indicate a running job.
    /// </summary>
    public enum ListPromoteAliasesResponseVariant2AliaseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPromoteAliasesResponseVariant2AliaseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPromoteAliasesResponseVariant2AliaseStatus value)
        {
            return value switch
            {
                ListPromoteAliasesResponseVariant2AliaseStatus.Completed => "completed",
                ListPromoteAliasesResponseVariant2AliaseStatus.Failed => "failed",
                ListPromoteAliasesResponseVariant2AliaseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPromoteAliasesResponseVariant2AliaseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListPromoteAliasesResponseVariant2AliaseStatus.Completed,
                "failed" => ListPromoteAliasesResponseVariant2AliaseStatus.Failed,
                "pending" => ListPromoteAliasesResponseVariant2AliaseStatus.Pending,
                _ => null,
            };
        }
    }
}