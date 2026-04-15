
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant247PreviousScope
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
    public static class UserEventPayloadVariant247PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant247PreviousScope.All => "all",
                UserEventPayloadVariant247PreviousScope.Private => "private",
                UserEventPayloadVariant247PreviousScope.Public => "public",
                UserEventPayloadVariant247PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant247PreviousScope.All,
                "private" => UserEventPayloadVariant247PreviousScope.Private,
                "public" => UserEventPayloadVariant247PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant247PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}