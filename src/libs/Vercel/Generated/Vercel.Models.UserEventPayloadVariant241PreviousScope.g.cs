
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant241PreviousScope
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
    public static class UserEventPayloadVariant241PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant241PreviousScope.All => "all",
                UserEventPayloadVariant241PreviousScope.Private => "private",
                UserEventPayloadVariant241PreviousScope.Public => "public",
                UserEventPayloadVariant241PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant241PreviousScope.All,
                "private" => UserEventPayloadVariant241PreviousScope.Private,
                "public" => UserEventPayloadVariant241PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant241PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}