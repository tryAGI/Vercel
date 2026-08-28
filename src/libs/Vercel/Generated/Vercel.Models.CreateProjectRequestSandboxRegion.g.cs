
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region sandboxes in this project are created in by default.<br/>
    /// Example: iad1
    /// </summary>
    public enum CreateProjectRequestSandboxRegion
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
    public static class CreateProjectRequestSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestSandboxRegion value)
        {
            return value switch
            {
                CreateProjectRequestSandboxRegion.Arn1 => "arn1",
                CreateProjectRequestSandboxRegion.Bom1 => "bom1",
                CreateProjectRequestSandboxRegion.Cdg1 => "cdg1",
                CreateProjectRequestSandboxRegion.Cle1 => "cle1",
                CreateProjectRequestSandboxRegion.Cpt1 => "cpt1",
                CreateProjectRequestSandboxRegion.Dub1 => "dub1",
                CreateProjectRequestSandboxRegion.Fra1 => "fra1",
                CreateProjectRequestSandboxRegion.Gru1 => "gru1",
                CreateProjectRequestSandboxRegion.Hkg1 => "hkg1",
                CreateProjectRequestSandboxRegion.Hnd1 => "hnd1",
                CreateProjectRequestSandboxRegion.Iad1 => "iad1",
                CreateProjectRequestSandboxRegion.Icn1 => "icn1",
                CreateProjectRequestSandboxRegion.Kix1 => "kix1",
                CreateProjectRequestSandboxRegion.Lhr1 => "lhr1",
                CreateProjectRequestSandboxRegion.Pdx1 => "pdx1",
                CreateProjectRequestSandboxRegion.Sfo1 => "sfo1",
                CreateProjectRequestSandboxRegion.Sin1 => "sin1",
                CreateProjectRequestSandboxRegion.Syd1 => "syd1",
                CreateProjectRequestSandboxRegion.Yul1 => "yul1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "arn1" => CreateProjectRequestSandboxRegion.Arn1,
                "bom1" => CreateProjectRequestSandboxRegion.Bom1,
                "cdg1" => CreateProjectRequestSandboxRegion.Cdg1,
                "cle1" => CreateProjectRequestSandboxRegion.Cle1,
                "cpt1" => CreateProjectRequestSandboxRegion.Cpt1,
                "dub1" => CreateProjectRequestSandboxRegion.Dub1,
                "fra1" => CreateProjectRequestSandboxRegion.Fra1,
                "gru1" => CreateProjectRequestSandboxRegion.Gru1,
                "hkg1" => CreateProjectRequestSandboxRegion.Hkg1,
                "hnd1" => CreateProjectRequestSandboxRegion.Hnd1,
                "iad1" => CreateProjectRequestSandboxRegion.Iad1,
                "icn1" => CreateProjectRequestSandboxRegion.Icn1,
                "kix1" => CreateProjectRequestSandboxRegion.Kix1,
                "lhr1" => CreateProjectRequestSandboxRegion.Lhr1,
                "pdx1" => CreateProjectRequestSandboxRegion.Pdx1,
                "sfo1" => CreateProjectRequestSandboxRegion.Sfo1,
                "sin1" => CreateProjectRequestSandboxRegion.Sin1,
                "syd1" => CreateProjectRequestSandboxRegion.Syd1,
                "yul1" => CreateProjectRequestSandboxRegion.Yul1,
                _ => null,
            };
        }
    }
}