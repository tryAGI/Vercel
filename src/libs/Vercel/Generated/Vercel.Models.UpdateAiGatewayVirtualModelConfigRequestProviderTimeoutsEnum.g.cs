
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum.x_default => "@default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum.x_default,
                _ => null,
            };
        }
    }
}