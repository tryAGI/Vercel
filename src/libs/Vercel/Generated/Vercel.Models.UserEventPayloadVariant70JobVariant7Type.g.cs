
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        GitlabNowComment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant7Type value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant7Type.GitlabNowComment => "gitlab-now-comment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab-now-comment" => UserEventPayloadVariant70JobVariant7Type.GitlabNowComment,
                _ => null,
            };
        }
    }
}