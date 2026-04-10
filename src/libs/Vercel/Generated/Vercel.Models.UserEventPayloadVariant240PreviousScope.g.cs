
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant240PreviousScope
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
    public static class UserEventPayloadVariant240PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant240PreviousScope.All => "all",
                UserEventPayloadVariant240PreviousScope.Private => "private",
                UserEventPayloadVariant240PreviousScope.Public => "public",
                UserEventPayloadVariant240PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant240PreviousScope.All,
                "private" => UserEventPayloadVariant240PreviousScope.Private,
                "public" => UserEventPayloadVariant240PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant240PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}