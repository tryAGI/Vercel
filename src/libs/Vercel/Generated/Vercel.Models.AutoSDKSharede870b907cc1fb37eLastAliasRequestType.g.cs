
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eLastAliasRequestType
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
    public static class AutoSDKSharede870b907cc1fb37eLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eLastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eLastAliasRequestType.Promote => "promote",
                AutoSDKSharede870b907cc1fb37eLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharede870b907cc1fb37eLastAliasRequestType.Promote,
                "rollback" => AutoSDKSharede870b907cc1fb37eLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}