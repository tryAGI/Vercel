
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant239PreviousScope
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
    public static class UserEventPayloadVariant239PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant239PreviousScope.All => "all",
                UserEventPayloadVariant239PreviousScope.Private => "private",
                UserEventPayloadVariant239PreviousScope.Public => "public",
                UserEventPayloadVariant239PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant239PreviousScope.All,
                "private" => UserEventPayloadVariant239PreviousScope.Private,
                "public" => UserEventPayloadVariant239PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant239PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}