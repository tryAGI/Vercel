
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant248PreviousScope
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
    public static class UserEventPayloadVariant248PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant248PreviousScope.All => "all",
                UserEventPayloadVariant248PreviousScope.Private => "private",
                UserEventPayloadVariant248PreviousScope.Public => "public",
                UserEventPayloadVariant248PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant248PreviousScope.All,
                "private" => UserEventPayloadVariant248PreviousScope.Private,
                "public" => UserEventPayloadVariant248PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant248PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}