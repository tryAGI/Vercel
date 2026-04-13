
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant242NextScope
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
    public static class UserEventPayloadVariant242NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant242NextScope.All => "all",
                UserEventPayloadVariant242NextScope.Private => "private",
                UserEventPayloadVariant242NextScope.Public => "public",
                UserEventPayloadVariant242NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant242NextScope.All,
                "private" => UserEventPayloadVariant242NextScope.Private,
                "public" => UserEventPayloadVariant242NextScope.Public,
                "selected_repos" => UserEventPayloadVariant242NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}