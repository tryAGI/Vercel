
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant241NextScope
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
    public static class UserEventPayloadVariant241NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant241NextScope.All => "all",
                UserEventPayloadVariant241NextScope.Private => "private",
                UserEventPayloadVariant241NextScope.Public => "public",
                UserEventPayloadVariant241NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant241NextScope.All,
                "private" => UserEventPayloadVariant241NextScope.Private,
                "public" => UserEventPayloadVariant241NextScope.Public,
                "selected_repos" => UserEventPayloadVariant241NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}