
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant253NextScope
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
    public static class UserEventPayloadVariant253NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant253NextScope.All => "all",
                UserEventPayloadVariant253NextScope.Private => "private",
                UserEventPayloadVariant253NextScope.Public => "public",
                UserEventPayloadVariant253NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant253NextScope.All,
                "private" => UserEventPayloadVariant253NextScope.Private,
                "public" => UserEventPayloadVariant253NextScope.Public,
                "selected_repos" => UserEventPayloadVariant253NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}