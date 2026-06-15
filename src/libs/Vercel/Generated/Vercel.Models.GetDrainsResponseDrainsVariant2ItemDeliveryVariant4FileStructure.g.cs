
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructure
    {
        /// <summary>
        /// 
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructure value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => GetDrainsResponseDrainsVariant2ItemDeliveryVariant4FileStructure.Hive,
                _ => null,
            };
        }
    }
}