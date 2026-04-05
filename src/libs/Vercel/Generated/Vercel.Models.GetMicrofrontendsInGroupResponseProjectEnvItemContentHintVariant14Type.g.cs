
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationStoreSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14Type.IntegrationStoreSecret => "integration-store-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-store-secret" => GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14Type.IntegrationStoreSecret,
                _ => null,
            };
        }
    }
}