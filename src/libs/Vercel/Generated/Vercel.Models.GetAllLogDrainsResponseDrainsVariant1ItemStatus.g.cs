
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant1ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemStatus value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemStatus.Disabled => "disabled",
                GetAllLogDrainsResponseDrainsVariant1ItemStatus.Enabled => "enabled",
                GetAllLogDrainsResponseDrainsVariant1ItemStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetAllLogDrainsResponseDrainsVariant1ItemStatus.Disabled,
                "enabled" => GetAllLogDrainsResponseDrainsVariant1ItemStatus.Enabled,
                "errored" => GetAllLogDrainsResponseDrainsVariant1ItemStatus.Errored,
                _ => null,
            };
        }
    }
}