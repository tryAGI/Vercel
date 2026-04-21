
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant249NextScope
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
    public static class UserEventPayloadVariant249NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant249NextScope.All => "all",
                UserEventPayloadVariant249NextScope.Private => "private",
                UserEventPayloadVariant249NextScope.Public => "public",
                UserEventPayloadVariant249NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant249NextScope.All,
                "private" => UserEventPayloadVariant249NextScope.Private,
                "public" => UserEventPayloadVariant249NextScope.Public,
                "selected_repos" => UserEventPayloadVariant249NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}