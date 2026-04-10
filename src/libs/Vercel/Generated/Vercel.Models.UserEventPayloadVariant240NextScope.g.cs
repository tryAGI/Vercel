
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant240NextScope
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
    public static class UserEventPayloadVariant240NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant240NextScope.All => "all",
                UserEventPayloadVariant240NextScope.Private => "private",
                UserEventPayloadVariant240NextScope.Public => "public",
                UserEventPayloadVariant240NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant240NextScope.All,
                "private" => UserEventPayloadVariant240NextScope.Private,
                "public" => UserEventPayloadVariant240NextScope.Public,
                "selected_repos" => UserEventPayloadVariant240NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}