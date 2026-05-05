
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant263PreviousScope
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
    public static class UserEventPayloadVariant263PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant263PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant263PreviousScope.All => "all",
                UserEventPayloadVariant263PreviousScope.Private => "private",
                UserEventPayloadVariant263PreviousScope.Public => "public",
                UserEventPayloadVariant263PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant263PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant263PreviousScope.All,
                "private" => UserEventPayloadVariant263PreviousScope.Private,
                "public" => UserEventPayloadVariant263PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant263PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}