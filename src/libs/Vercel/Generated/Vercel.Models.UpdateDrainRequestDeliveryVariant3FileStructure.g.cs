
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDrainRequestDeliveryVariant3FileStructure
    {
        /// <summary>
        ///
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainRequestDeliveryVariant3FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestDeliveryVariant3FileStructure value)
        {
            return value switch
            {
                UpdateDrainRequestDeliveryVariant3FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestDeliveryVariant3FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => UpdateDrainRequestDeliveryVariant3FileStructure.Hive,
                _ => null,
            };
        }
    }
}