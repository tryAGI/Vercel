
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter by token status. Omit or use `all` to include every status.
    /// </summary>
    public enum ListAuthTokensStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAuthTokensStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAuthTokensStatus value)
        {
            return value switch
            {
                ListAuthTokensStatus.Active => "active",
                ListAuthTokensStatus.All => "all",
                ListAuthTokensStatus.Expired => "expired",
                ListAuthTokensStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAuthTokensStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListAuthTokensStatus.Active,
                "all" => ListAuthTokensStatus.All,
                "expired" => ListAuthTokensStatus.Expired,
                "revoked" => ListAuthTokensStatus.Revoked,
                _ => null,
            };
        }
    }
}