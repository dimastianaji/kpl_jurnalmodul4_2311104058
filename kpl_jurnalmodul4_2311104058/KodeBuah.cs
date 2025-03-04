using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpl_jurnalmodul4_2311104058
{
    class KodeBuah
    {
        private Dictionary<string, string> kodeBuah = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"}
    };

        public string getKodeBuah(string namaBuah)
        {
            if (kodeBuah.ContainsKey(namaBuah))
            {
                return kodeBuah[namaBuah];
            }
            else
            {
                return "Kode tidak ditemukan";
            }
        }
    }
}
