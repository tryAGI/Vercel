
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant251NextScope
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
    public static class UserEventPayloadVariant251NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant251NextScope.All => "all",
                UserEventPayloadVariant251NextScope.Private => "private",
                UserEventPayloadVariant251NextScope.Public => "public",
                UserEventPayloadVariant251NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant251NextScope.All,
                "private" => UserEventPayloadVariant251NextScope.Private,
                "public" => UserEventPayloadVariant251NextScope.Public,
                "selected_repos" => UserEventPayloadVariant251NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}