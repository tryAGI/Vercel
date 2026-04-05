
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemStatus
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemStatus value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemStatus.Disabled => "disabled",
                GetAllLogDrainsResponseDrainsVariant2ItemStatus.Enabled => "enabled",
                GetAllLogDrainsResponseDrainsVariant2ItemStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetAllLogDrainsResponseDrainsVariant2ItemStatus.Disabled,
                "enabled" => GetAllLogDrainsResponseDrainsVariant2ItemStatus.Enabled,
                "errored" => GetAllLogDrainsResponseDrainsVariant2ItemStatus.Errored,
                _ => null,
            };
        }
    }
}