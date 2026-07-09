
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant3Variant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        AliasAssigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentEventsResponseVariant3Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant3Variant3Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant3Variant3Type.AliasAssigned => "alias-assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant3Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "alias-assigned" => GetDeploymentEventsResponseVariant3Variant3Type.AliasAssigned,
                _ => null,
            };
        }
    }
}