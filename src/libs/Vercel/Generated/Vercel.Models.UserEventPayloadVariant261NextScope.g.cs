
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant261NextScope
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
    public static class UserEventPayloadVariant261NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant261NextScope.All => "all",
                UserEventPayloadVariant261NextScope.Private => "private",
                UserEventPayloadVariant261NextScope.Public => "public",
                UserEventPayloadVariant261NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant261NextScope.All,
                "private" => UserEventPayloadVariant261NextScope.Private,
                "public" => UserEventPayloadVariant261NextScope.Public,
                "selected_repos" => UserEventPayloadVariant261NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}