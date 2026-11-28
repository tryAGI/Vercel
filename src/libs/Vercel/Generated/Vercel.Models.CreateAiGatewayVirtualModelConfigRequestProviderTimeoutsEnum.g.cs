
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum.x_default => "@default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum? ToEnum(string value)
        {
            return value switch
            {
                "@default" => CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum.x_default,
                _ => null,
            };
        }
    }
}