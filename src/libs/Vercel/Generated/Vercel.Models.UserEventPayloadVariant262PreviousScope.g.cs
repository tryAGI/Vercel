
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant262PreviousScope
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
    public static class UserEventPayloadVariant262PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant262PreviousScope.All => "all",
                UserEventPayloadVariant262PreviousScope.Private => "private",
                UserEventPayloadVariant262PreviousScope.Public => "public",
                UserEventPayloadVariant262PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant262PreviousScope.All,
                "private" => UserEventPayloadVariant262PreviousScope.Private,
                "public" => UserEventPayloadVariant262PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant262PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}