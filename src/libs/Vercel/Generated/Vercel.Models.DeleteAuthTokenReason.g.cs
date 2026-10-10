
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Identifies an explicit logout for the deletion event. Only applies when tokenId is current.
    /// </summary>
    public enum DeleteAuthTokenReason
    {
        /// <summary>
        ///
        /// </summary>
        Logout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAuthTokenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAuthTokenReason value)
        {
            return value switch
            {
                DeleteAuthTokenReason.Logout => "logout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAuthTokenReason? ToEnum(string value)
        {
            return value switch
            {
                "logout" => DeleteAuthTokenReason.Logout,
                _ => null,
            };
        }
    }
}