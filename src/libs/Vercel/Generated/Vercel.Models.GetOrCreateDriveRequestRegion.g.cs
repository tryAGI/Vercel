
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Region where the drive is stored. Defaults to iad1.<br/>
    /// Default Value: iad1<br/>
    /// Example: iad1
    /// </summary>
    public enum GetOrCreateDriveRequestRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cdg1,
        /// <summary>
        /// 
        /// </summary>
        Cle1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrCreateDriveRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrCreateDriveRequestRegion value)
        {
            return value switch
            {
                GetOrCreateDriveRequestRegion.Cdg1 => "cdg1",
                GetOrCreateDriveRequestRegion.Cle1 => "cle1",
                GetOrCreateDriveRequestRegion.Iad1 => "iad1",
                GetOrCreateDriveRequestRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrCreateDriveRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetOrCreateDriveRequestRegion.Cdg1,
                "cle1" => GetOrCreateDriveRequestRegion.Cle1,
                "iad1" => GetOrCreateDriveRequestRegion.Iad1,
                "sfo1" => GetOrCreateDriveRequestRegion.Sfo1,
                _ => null,
            };
        }
    }
}