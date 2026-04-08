
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant238PreviousScope
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        SelectedRepos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant238PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant238PreviousScope.All => "all",
                UserEventPayloadVariant238PreviousScope.Private => "private",
                UserEventPayloadVariant238PreviousScope.Public => "public",
                UserEventPayloadVariant238PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant238PreviousScope.All,
                "private" => UserEventPayloadVariant238PreviousScope.Private,
                "public" => UserEventPayloadVariant238PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant238PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}