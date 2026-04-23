
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant251PreviousScope
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
    public static class UserEventPayloadVariant251PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant251PreviousScope.All => "all",
                UserEventPayloadVariant251PreviousScope.Private => "private",
                UserEventPayloadVariant251PreviousScope.Public => "public",
                UserEventPayloadVariant251PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant251PreviousScope.All,
                "private" => UserEventPayloadVariant251PreviousScope.Private,
                "public" => UserEventPayloadVariant251PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant251PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}