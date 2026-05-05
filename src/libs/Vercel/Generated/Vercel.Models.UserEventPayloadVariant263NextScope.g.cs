
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant263NextScope
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
    public static class UserEventPayloadVariant263NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant263NextScope.All => "all",
                UserEventPayloadVariant263NextScope.Private => "private",
                UserEventPayloadVariant263NextScope.Public => "public",
                UserEventPayloadVariant263NextScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263NextScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant263NextScope.All,
                "private" => UserEventPayloadVariant263NextScope.Private,
                "public" => UserEventPayloadVariant263NextScope.Public,
                "selected_repos" => UserEventPayloadVariant263NextScope.SelectedRepos,
                _ => null,
            };
        }
    }
}