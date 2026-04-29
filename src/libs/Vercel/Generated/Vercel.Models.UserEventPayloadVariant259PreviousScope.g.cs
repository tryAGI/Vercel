
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which repository visibilities get automatic reviews
    /// </summary>
    public enum UserEventPayloadVariant259PreviousScope
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
    public static class UserEventPayloadVariant259PreviousScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259PreviousScope value)
        {
            return value switch
            {
                UserEventPayloadVariant259PreviousScope.All => "all",
                UserEventPayloadVariant259PreviousScope.Private => "private",
                UserEventPayloadVariant259PreviousScope.Public => "public",
                UserEventPayloadVariant259PreviousScope.SelectedRepos => "selected_repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259PreviousScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant259PreviousScope.All,
                "private" => UserEventPayloadVariant259PreviousScope.Private,
                "public" => UserEventPayloadVariant259PreviousScope.Public,
                "selected_repos" => UserEventPayloadVariant259PreviousScope.SelectedRepos,
                _ => null,
            };
        }
    }
}