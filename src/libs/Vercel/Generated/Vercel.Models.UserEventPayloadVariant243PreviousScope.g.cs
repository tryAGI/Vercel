
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant243PreviousScope
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
    public static class UserEventPayloadVariant243PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant243PreviousScope.All => "all",
                UserEventPayloadVariant243PreviousScope.Private => "private",
                UserEventPayloadVariant243PreviousScope.Public => "public",
                UserEventPayloadVariant243PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant243PreviousScope.All,
                "private" => UserEventPayloadVariant243PreviousScope.Private,
                "public" => UserEventPayloadVariant243PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant243PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}