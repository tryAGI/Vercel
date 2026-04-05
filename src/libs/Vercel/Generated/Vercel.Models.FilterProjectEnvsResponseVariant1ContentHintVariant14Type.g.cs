
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1ContentHintVariant14Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationStoreSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1ContentHintVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1ContentHintVariant14Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1ContentHintVariant14Type.IntegrationStoreSecret => "integration-store-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1ContentHintVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-store-secret" => FilterProjectEnvsResponseVariant1ContentHintVariant14Type.IntegrationStoreSecret,
                _ => null,
            };
        }
    }
}