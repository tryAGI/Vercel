
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant236PreviousScope
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
    public static class UserEventPayloadVariant236PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant236PreviousScope.All => "all",
                UserEventPayloadVariant236PreviousScope.Private => "private",
                UserEventPayloadVariant236PreviousScope.Public => "public",
                UserEventPayloadVariant236PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant236PreviousScope.All,
                "private" => UserEventPayloadVariant236PreviousScope.Private,
                "public" => UserEventPayloadVariant236PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant236PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}