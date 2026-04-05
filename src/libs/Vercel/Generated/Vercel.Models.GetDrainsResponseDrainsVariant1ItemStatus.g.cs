
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemStatus
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
    public static class GetDrainsResponseDrainsVariant1ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemStatus value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemStatus.Disabled => "disabled",
                GetDrainsResponseDrainsVariant1ItemStatus.Enabled => "enabled",
                GetDrainsResponseDrainsVariant1ItemStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetDrainsResponseDrainsVariant1ItemStatus.Disabled,
                "enabled" => GetDrainsResponseDrainsVariant1ItemStatus.Enabled,
                "errored" => GetDrainsResponseDrainsVariant1ItemStatus.Errored,
                _ => null,
            };
        }
    }
}