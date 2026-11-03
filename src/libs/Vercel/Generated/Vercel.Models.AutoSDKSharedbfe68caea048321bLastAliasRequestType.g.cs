
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bLastAliasRequestType
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
    public static class AutoSDKSharedbfe68caea048321bLastAliasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bLastAliasRequestType value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bLastAliasRequestType.Promote => "promote",
                AutoSDKSharedbfe68caea048321bLastAliasRequestType.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bLastAliasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "promote" => AutoSDKSharedbfe68caea048321bLastAliasRequestType.Promote,
                "rollback" => AutoSDKSharedbfe68caea048321bLastAliasRequestType.Rollback,
                _ => null,
            };
        }
    }
}