
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant252NextScope
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
    public static class UserEventPayloadVariant252NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant252NextScope.All => "all",
                UserEventPayloadVariant252NextScope.Private => "private",
                UserEventPayloadVariant252NextScope.Public => "public",
                UserEventPayloadVariant252NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant252NextScope.All,
                "private" => UserEventPayloadVariant252NextScope.Private,
                "public" => UserEventPayloadVariant252NextScope.Public,
                "selected_repos" => UserEventPayloadVariant252NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}