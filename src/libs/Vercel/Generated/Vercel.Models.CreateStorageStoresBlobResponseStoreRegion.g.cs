
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Arn1,
        /// <summary>
        /// 
        /// </summary>
        Bom1,
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
        Cpt1,
        /// <summary>
        /// 
        /// </summary>
        Dub1,
        /// <summary>
        /// 
        /// </summary>
        Dxb1,
        /// <summary>
        /// 
        /// </summary>
        Fra1,
        /// <summary>
        /// 
        /// </summary>
        Gru1,
        /// <summary>
        /// 
        /// </summary>
        Hkg1,
        /// <summary>
        /// 
        /// </summary>
        Hnd1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Icn1,
        /// <summary>
        /// 
        /// </summary>
        Kix1,
        /// <summary>
        /// 
        /// </summary>
        Lhr1,
        /// <summary>
        /// 
        /// </summary>
        Pdx1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
        /// <summary>
        /// 
        /// </summary>
        Sin1,
        /// <summary>
        /// 
        /// </summary>
        Syd1,
        /// <summary>
        /// 
        /// </summary>
        Yul1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStorageStoresBlobResponseStoreRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreRegion value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreRegion.Arn1 => "arn1",
                CreateStorageStoresBlobResponseStoreRegion.Bom1 => "bom1",
                CreateStorageStoresBlobResponseStoreRegion.Cdg1 => "cdg1",
                CreateStorageStoresBlobResponseStoreRegion.Cle1 => "cle1",
                CreateStorageStoresBlobResponseStoreRegion.Cpt1 => "cpt1",
                CreateStorageStoresBlobResponseStoreRegion.Dub1 => "dub1",
                CreateStorageStoresBlobResponseStoreRegion.Dxb1 => "dxb1",
                CreateStorageStoresBlobResponseStoreRegion.Fra1 => "fra1",
                CreateStorageStoresBlobResponseStoreRegion.Gru1 => "gru1",
                CreateStorageStoresBlobResponseStoreRegion.Hkg1 => "hkg1",
                CreateStorageStoresBlobResponseStoreRegion.Hnd1 => "hnd1",
                CreateStorageStoresBlobResponseStoreRegion.Iad1 => "iad1",
                CreateStorageStoresBlobResponseStoreRegion.Icn1 => "icn1",
                CreateStorageStoresBlobResponseStoreRegion.Kix1 => "kix1",
                CreateStorageStoresBlobResponseStoreRegion.Lhr1 => "lhr1",
                CreateStorageStoresBlobResponseStoreRegion.Pdx1 => "pdx1",
                CreateStorageStoresBlobResponseStoreRegion.Sfo1 => "sfo1",
                CreateStorageStoresBlobResponseStoreRegion.Sin1 => "sin1",
                CreateStorageStoresBlobResponseStoreRegion.Syd1 => "syd1",
                CreateStorageStoresBlobResponseStoreRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateStorageStoresBlobResponseStoreRegion.Arn1,
                "bom1" => CreateStorageStoresBlobResponseStoreRegion.Bom1,
                "cdg1" => CreateStorageStoresBlobResponseStoreRegion.Cdg1,
                "cle1" => CreateStorageStoresBlobResponseStoreRegion.Cle1,
                "cpt1" => CreateStorageStoresBlobResponseStoreRegion.Cpt1,
                "dub1" => CreateStorageStoresBlobResponseStoreRegion.Dub1,
                "dxb1" => CreateStorageStoresBlobResponseStoreRegion.Dxb1,
                "fra1" => CreateStorageStoresBlobResponseStoreRegion.Fra1,
                "gru1" => CreateStorageStoresBlobResponseStoreRegion.Gru1,
                "hkg1" => CreateStorageStoresBlobResponseStoreRegion.Hkg1,
                "hnd1" => CreateStorageStoresBlobResponseStoreRegion.Hnd1,
                "iad1" => CreateStorageStoresBlobResponseStoreRegion.Iad1,
                "icn1" => CreateStorageStoresBlobResponseStoreRegion.Icn1,
                "kix1" => CreateStorageStoresBlobResponseStoreRegion.Kix1,
                "lhr1" => CreateStorageStoresBlobResponseStoreRegion.Lhr1,
                "pdx1" => CreateStorageStoresBlobResponseStoreRegion.Pdx1,
                "sfo1" => CreateStorageStoresBlobResponseStoreRegion.Sfo1,
                "sin1" => CreateStorageStoresBlobResponseStoreRegion.Sin1,
                "syd1" => CreateStorageStoresBlobResponseStoreRegion.Syd1,
                "yul1" => CreateStorageStoresBlobResponseStoreRegion.Yul1,
                _ => null,
            };
        }
    }
}