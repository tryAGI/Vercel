
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructure
    {
        /// <summary>
        ///
        /// </summary>
        Hive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructure value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructure.Hive => "hive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructure? ToEnum(string value)
        {
            return value switch
            {
                "hive" => AutoSDKShared383028c008cc4ae0DeliveryVariant4FileStructure.Hive,
                _ => null,
            };
        }
    }
}