
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStorageStoresBlobRequestRegion
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
    public static class CreateStorageStoresBlobRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobRequestRegion value)
        {
            return value switch
            {
                CreateStorageStoresBlobRequestRegion.Arn1 => "arn1",
                CreateStorageStoresBlobRequestRegion.Bom1 => "bom1",
                CreateStorageStoresBlobRequestRegion.Cdg1 => "cdg1",
                CreateStorageStoresBlobRequestRegion.Cle1 => "cle1",
                CreateStorageStoresBlobRequestRegion.Cpt1 => "cpt1",
                CreateStorageStoresBlobRequestRegion.Dub1 => "dub1",
                CreateStorageStoresBlobRequestRegion.Dxb1 => "dxb1",
                CreateStorageStoresBlobRequestRegion.Fra1 => "fra1",
                CreateStorageStoresBlobRequestRegion.Gru1 => "gru1",
                CreateStorageStoresBlobRequestRegion.Hkg1 => "hkg1",
                CreateStorageStoresBlobRequestRegion.Hnd1 => "hnd1",
                CreateStorageStoresBlobRequestRegion.Iad1 => "iad1",
                CreateStorageStoresBlobRequestRegion.Icn1 => "icn1",
                CreateStorageStoresBlobRequestRegion.Kix1 => "kix1",
                CreateStorageStoresBlobRequestRegion.Lhr1 => "lhr1",
                CreateStorageStoresBlobRequestRegion.Pdx1 => "pdx1",
                CreateStorageStoresBlobRequestRegion.Sfo1 => "sfo1",
                CreateStorageStoresBlobRequestRegion.Sin1 => "sin1",
                CreateStorageStoresBlobRequestRegion.Syd1 => "syd1",
                CreateStorageStoresBlobRequestRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateStorageStoresBlobRequestRegion.Arn1,
                "bom1" => CreateStorageStoresBlobRequestRegion.Bom1,
                "cdg1" => CreateStorageStoresBlobRequestRegion.Cdg1,
                "cle1" => CreateStorageStoresBlobRequestRegion.Cle1,
                "cpt1" => CreateStorageStoresBlobRequestRegion.Cpt1,
                "dub1" => CreateStorageStoresBlobRequestRegion.Dub1,
                "dxb1" => CreateStorageStoresBlobRequestRegion.Dxb1,
                "fra1" => CreateStorageStoresBlobRequestRegion.Fra1,
                "gru1" => CreateStorageStoresBlobRequestRegion.Gru1,
                "hkg1" => CreateStorageStoresBlobRequestRegion.Hkg1,
                "hnd1" => CreateStorageStoresBlobRequestRegion.Hnd1,
                "iad1" => CreateStorageStoresBlobRequestRegion.Iad1,
                "icn1" => CreateStorageStoresBlobRequestRegion.Icn1,
                "kix1" => CreateStorageStoresBlobRequestRegion.Kix1,
                "lhr1" => CreateStorageStoresBlobRequestRegion.Lhr1,
                "pdx1" => CreateStorageStoresBlobRequestRegion.Pdx1,
                "sfo1" => CreateStorageStoresBlobRequestRegion.Sfo1,
                "sin1" => CreateStorageStoresBlobRequestRegion.Sin1,
                "syd1" => CreateStorageStoresBlobRequestRegion.Syd1,
                "yul1" => CreateStorageStoresBlobRequestRegion.Yul1,
                _ => null,
            };
        }
    }
}