
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3ContentHintVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationStoreSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant3ContentHintVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3ContentHintVariant14Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3ContentHintVariant14Type.IntegrationStoreSecret => "integration-store-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3ContentHintVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-store-secret" => RemoveProjectEnvResponseVariant3ContentHintVariant14Type.IntegrationStoreSecret,
                _ => null,
            };
        }
    }
}