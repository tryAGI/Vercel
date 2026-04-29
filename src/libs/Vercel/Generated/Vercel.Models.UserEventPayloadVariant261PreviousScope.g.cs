
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant261PreviousScope
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
    public static class UserEventPayloadVariant261PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant261PreviousScope.All => "all",
                UserEventPayloadVariant261PreviousScope.Private => "private",
                UserEventPayloadVariant261PreviousScope.Public => "public",
                UserEventPayloadVariant261PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant261PreviousScope.All,
                "private" => UserEventPayloadVariant261PreviousScope.Private,
                "public" => UserEventPayloadVariant261PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant261PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}