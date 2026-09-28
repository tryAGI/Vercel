
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fLastAliasRequestType
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
    public static class AutoSDKShareda223f19b9c37327fLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fLastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fLastAliasRequestType.Promote => "promote",
                AutoSDKShareda223f19b9c37327fLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKShareda223f19b9c37327fLastAliasRequestType.Promote,
                "rollback" => AutoSDKShareda223f19b9c37327fLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}