
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant4FileStructure
    {
        /// <summary>
        ///
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant1DeliveryVariant4FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant4FileStructure value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant4FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant4FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => UpdateDrainResponseVariant1DeliveryVariant4FileStructure.Hive,
                _ => null,
            };
        }
    }
}