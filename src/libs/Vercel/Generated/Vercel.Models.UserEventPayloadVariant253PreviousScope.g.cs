
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant253PreviousScope
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
    public static class UserEventPayloadVariant253PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant253PreviousScope.All => "all",
                UserEventPayloadVariant253PreviousScope.Private => "private",
                UserEventPayloadVariant253PreviousScope.Public => "public",
                UserEventPayloadVariant253PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant253PreviousScope.All,
                "private" => UserEventPayloadVariant253PreviousScope.Private,
                "public" => UserEventPayloadVariant253PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant253PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}