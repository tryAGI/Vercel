
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant236NextScope
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
    public static class UserEventPayloadVariant236NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant236NextScope.All => "all",
                UserEventPayloadVariant236NextScope.Private => "private",
                UserEventPayloadVariant236NextScope.Public => "public",
                UserEventPayloadVariant236NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant236NextScope.All,
                "private" => UserEventPayloadVariant236NextScope.Private,
                "public" => UserEventPayloadVariant236NextScope.Public,
                "selected_repos" => UserEventPayloadVariant236NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}