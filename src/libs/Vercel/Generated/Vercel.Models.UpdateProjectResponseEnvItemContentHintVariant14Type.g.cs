
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemContentHintVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationStoreSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemContentHintVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemContentHintVariant14Type value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemContentHintVariant14Type.IntegrationStoreSecret => "integration-store-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemContentHintVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-store-secret" => UpdateProjectResponseEnvItemContentHintVariant14Type.IntegrationStoreSecret,
                _ => null,
            };
        }
    }
}