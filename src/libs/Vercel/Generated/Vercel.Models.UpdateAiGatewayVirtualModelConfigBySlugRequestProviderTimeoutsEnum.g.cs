
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum.x_default => "@default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum.x_default,
                _ => null,
            };
        }
    }
}