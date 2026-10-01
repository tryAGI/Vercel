
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb65d769b106737aBlockAction
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb65d769b106737aBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb65d769b106737aBlockAction value)
        {
            return value switch
            {
                AutoSDKShareddb65d769b106737aBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb65d769b106737aBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AutoSDKShareddb65d769b106737aBlockAction.Blocked,
                _ => null,
            };
        }
    }
}