
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotAuthorizedForScopeCode
    {
        /// <summary>
        /// 
        /// </summary>
        NotAuthorizedForScope,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotAuthorizedForScopeCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotAuthorizedForScopeCode value)
        {
            return value switch
            {
                NotAuthorizedForScopeCode.NotAuthorizedForScope => "not_authorized_for_scope",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotAuthorizedForScopeCode? ToEnum(string value)
        {
            return value switch
            {
                "not_authorized_for_scope" => NotAuthorizedForScopeCode.NotAuthorizedForScope,
                _ => null,
            };
        }
    }
}