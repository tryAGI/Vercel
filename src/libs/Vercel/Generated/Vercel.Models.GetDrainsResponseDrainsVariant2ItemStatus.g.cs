
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemStatus
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
    public static class GetDrainsResponseDrainsVariant2ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemStatus value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemStatus.Disabled => "disabled",
                GetDrainsResponseDrainsVariant2ItemStatus.Enabled => "enabled",
                GetDrainsResponseDrainsVariant2ItemStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetDrainsResponseDrainsVariant2ItemStatus.Disabled,
                "enabled" => GetDrainsResponseDrainsVariant2ItemStatus.Enabled,
                "errored" => GetDrainsResponseDrainsVariant2ItemStatus.Errored,
                _ => null,
            };
        }
    }
}