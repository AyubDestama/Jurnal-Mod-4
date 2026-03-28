using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400062
{
    public class KodePaket
    {
        public string getKodePaket(string namaPaket)
        {
            switch (namaPaket.ToLower())
            {
                case "basic": return "P201";
                case "standard": return "P202";
                case "premium": return "P203";
                case "unlimited": return "P204";
                case "gaming": return "P205";
                case "streaming": return "P206";
                case "family": return "P207";
                case "business": return "P208";
                case "student": return "P209";
                case "traveler": return "P210";
                default: return "Kode tidak ditemukan";
            }
        }
    }
}