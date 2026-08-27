
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TestDrainRequestDeliveryVariant3FileStructure
    {
        /// <summary>
        ///
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestDrainRequestDeliveryVariant3FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant3FileStructure value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant3FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant3FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => TestDrainRequestDeliveryVariant3FileStructure.Hive,
                _ => null,
            };
        }
    }
}