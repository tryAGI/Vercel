
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant262NextScope
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
    public static class UserEventPayloadVariant262NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant262NextScope.All => "all",
                UserEventPayloadVariant262NextScope.Private => "private",
                UserEventPayloadVariant262NextScope.Public => "public",
                UserEventPayloadVariant262NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant262NextScope.All,
                "private" => UserEventPayloadVariant262NextScope.Private,
                "public" => UserEventPayloadVariant262NextScope.Public,
                "selected_repos" => UserEventPayloadVariant262NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}