
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        GitlabPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant76JobVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant6Type value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant6Type.GitlabPush => "gitlab-push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab-push" => UserEventPayloadVariant76JobVariant6Type.GitlabPush,
                _ => null,
            };
        }
    }
}