
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant249PreviousScope
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
    public static class UserEventPayloadVariant249PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant249PreviousScope.All => "all",
                UserEventPayloadVariant249PreviousScope.Private => "private",
                UserEventPayloadVariant249PreviousScope.Public => "public",
                UserEventPayloadVariant249PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant249PreviousScope.All,
                "private" => UserEventPayloadVariant249PreviousScope.Private,
                "public" => UserEventPayloadVariant249PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant249PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}