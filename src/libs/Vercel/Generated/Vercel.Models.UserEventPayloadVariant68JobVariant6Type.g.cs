
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant68JobVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        GitlabPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant68JobVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant68JobVariant6Type value)
        {
            return value switch
            {
                UserEventPayloadVariant68JobVariant6Type.GitlabPush => "gitlab-push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant68JobVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab-push" => UserEventPayloadVariant68JobVariant6Type.GitlabPush,
                _ => null,
            };
        }
    }
}