
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant259NextScope
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
    public static class UserEventPayloadVariant259NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant259NextScope.All => "all",
                UserEventPayloadVariant259NextScope.Private => "private",
                UserEventPayloadVariant259NextScope.Public => "public",
                UserEventPayloadVariant259NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant259NextScope.All,
                "private" => UserEventPayloadVariant259NextScope.Private,
                "public" => UserEventPayloadVariant259NextScope.Public,
                "selected_repos" => UserEventPayloadVariant259NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}