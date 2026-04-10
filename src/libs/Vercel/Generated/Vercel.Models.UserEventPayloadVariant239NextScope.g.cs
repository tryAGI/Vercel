
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant239NextScope
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
    public static class UserEventPayloadVariant239NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant239NextScope.All => "all",
                UserEventPayloadVariant239NextScope.Private => "private",
                UserEventPayloadVariant239NextScope.Public => "public",
                UserEventPayloadVariant239NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant239NextScope.All,
                "private" => UserEventPayloadVariant239NextScope.Private,
                "public" => UserEventPayloadVariant239NextScope.Public,
                "selected_repos" => UserEventPayloadVariant239NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}