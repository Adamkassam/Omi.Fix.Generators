﻿namespace Omi.Fix.Fields {

    #pragma warning disable CS8618

    /// <summary>
    ///  Load fixml field elements into generated object classes
    /// </summary>
    public static class Load { 

        /// <summary>
        ///  Load fields from file path
        /// </summary>
        public static Omi.Fix.Fields.Xml.FixFields From(string xml) 
            => Fix.Load.From<Xml.FixFields>(xml);
    }
}