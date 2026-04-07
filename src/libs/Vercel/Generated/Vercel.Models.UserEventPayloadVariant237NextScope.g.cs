
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant237NextScope
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
    public static class UserEventPayloadVariant237NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant237NextScope.All => "all",
                UserEventPayloadVariant237NextScope.Private => "private",
                UserEventPayloadVariant237NextScope.Public => "public",
                UserEventPayloadVariant237NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant237NextScope.All,
                "private" => UserEventPayloadVariant237NextScope.Private,
                "public" => UserEventPayloadVariant237NextScope.Public,
                "selected_repos" => UserEventPayloadVariant237NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}