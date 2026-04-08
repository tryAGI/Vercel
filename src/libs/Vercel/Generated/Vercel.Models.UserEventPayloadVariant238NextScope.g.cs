
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant238NextScope
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
    public static class UserEventPayloadVariant238NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant238NextScope.All => "all",
                UserEventPayloadVariant238NextScope.Private => "private",
                UserEventPayloadVariant238NextScope.Public => "public",
                UserEventPayloadVariant238NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant238NextScope.All,
                "private" => UserEventPayloadVariant238NextScope.Private,
                "public" => UserEventPayloadVariant238NextScope.Public,
                "selected_repos" => UserEventPayloadVariant238NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}