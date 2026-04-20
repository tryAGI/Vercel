
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant248NextScope
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
    public static class UserEventPayloadVariant248NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant248NextScope.All => "all",
                UserEventPayloadVariant248NextScope.Private => "private",
                UserEventPayloadVariant248NextScope.Public => "public",
                UserEventPayloadVariant248NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant248NextScope.All,
                "private" => UserEventPayloadVariant248NextScope.Private,
                "public" => UserEventPayloadVariant248NextScope.Public,
                "selected_repos" => UserEventPayloadVariant248NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}