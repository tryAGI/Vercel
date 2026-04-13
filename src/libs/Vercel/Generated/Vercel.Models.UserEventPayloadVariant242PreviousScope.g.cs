
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant242PreviousScope
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
    public static class UserEventPayloadVariant242PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant242PreviousScope.All => "all",
                UserEventPayloadVariant242PreviousScope.Private => "private",
                UserEventPayloadVariant242PreviousScope.Public => "public",
                UserEventPayloadVariant242PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant242PreviousScope.All,
                "private" => UserEventPayloadVariant242PreviousScope.Private,
                "public" => UserEventPayloadVariant242PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant242PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}