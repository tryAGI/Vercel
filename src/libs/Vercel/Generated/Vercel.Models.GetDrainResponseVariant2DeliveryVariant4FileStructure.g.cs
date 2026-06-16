
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2DeliveryVariant4FileStructure
    {
        /// <summary>
        /// 
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2DeliveryVariant4FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2DeliveryVariant4FileStructure value)
        {
            return value switch
            {
                GetDrainResponseVariant2DeliveryVariant4FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2DeliveryVariant4FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => GetDrainResponseVariant2DeliveryVariant4FileStructure.Hive,
                _ => null,
            };
        }
    }
}