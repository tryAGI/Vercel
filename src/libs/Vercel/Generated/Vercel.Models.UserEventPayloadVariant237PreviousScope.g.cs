
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant237PreviousScope
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
    public static class UserEventPayloadVariant237PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant237PreviousScope.All => "all",
                UserEventPayloadVariant237PreviousScope.Private => "private",
                UserEventPayloadVariant237PreviousScope.Public => "public",
                UserEventPayloadVariant237PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant237PreviousScope.All,
                "private" => UserEventPayloadVariant237PreviousScope.Private,
                "public" => UserEventPayloadVariant237PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant237PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}