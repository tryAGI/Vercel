
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant247NextScope
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
    public static class UserEventPayloadVariant247NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant247NextScope.All => "all",
                UserEventPayloadVariant247NextScope.Private => "private",
                UserEventPayloadVariant247NextScope.Public => "public",
                UserEventPayloadVariant247NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant247NextScope.All,
                "private" => UserEventPayloadVariant247NextScope.Private,
                "public" => UserEventPayloadVariant247NextScope.Public,
                "selected_repos" => UserEventPayloadVariant247NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}