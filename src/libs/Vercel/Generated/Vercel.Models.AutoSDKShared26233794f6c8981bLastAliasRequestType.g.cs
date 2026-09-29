
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bLastAliasRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Promote,
        /// <summary>
        ///
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared26233794f6c8981bLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bLastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bLastAliasRequestType.Promote => "promote",
                AutoSDKShared26233794f6c8981bLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShared26233794f6c8981bLastAliasRequestType.Promote,
                "rollback" => AutoSDKShared26233794f6c8981bLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}