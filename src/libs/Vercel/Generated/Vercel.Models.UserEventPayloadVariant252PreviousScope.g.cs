
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant252PreviousScope
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
    public static class UserEventPayloadVariant252PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant252PreviousScope.All => "all",
                UserEventPayloadVariant252PreviousScope.Private => "private",
                UserEventPayloadVariant252PreviousScope.Public => "public",
                UserEventPayloadVariant252PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant252PreviousScope.All,
                "private" => UserEventPayloadVariant252PreviousScope.Private,
                "public" => UserEventPayloadVariant252PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant252PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}