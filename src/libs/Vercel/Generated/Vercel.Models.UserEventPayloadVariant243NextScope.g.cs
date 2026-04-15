
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant243NextScope
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
    public static class UserEventPayloadVariant243NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant243NextScope.All => "all",
                UserEventPayloadVariant243NextScope.Private => "private",
                UserEventPayloadVariant243NextScope.Public => "public",
                UserEventPayloadVariant243NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant243NextScope.All,
                "private" => UserEventPayloadVariant243NextScope.Private,
                "public" => UserEventPayloadVariant243NextScope.Public,
                "selected_repos" => UserEventPayloadVariant243NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}