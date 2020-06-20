using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "MITKTAKTIOUISBWFLWZLMAFMOAMTRKWDGKLMIAMMITOKDABZTAFTXTFMOFMITZTUOFFOFUGYPWSB."
                + "LGDTMIOFU AZGWM SALM DAF LMAFROFU, A ZWFEI GY KGWFRL, HTGHST RKTLLTR WH OF EGLMWDTL COMI YAQT FADTL YGK TXTKB KGWFR?"
                + "LGWFRL SOQT A ZWFEI GY FGFLTFLT MG DT, ZWM O'SS QTTH DB TAK MG MIT UKGWFR AFR DAQT LWKT MG STM BGW QFGC OY O ITAK TVAEM RAMTL."
                + "LMAB MWFTR YGK A YGKDAS AFFGWFETDTFM YGK MIT LAOFM XASTFMOFTL RAB LWDDTK DALLAEKT.";

            var theKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var crackingArray = new CrackingArray(theKey);

            string[] splitInput = input.Split('?', '.');
            var foundSensibleSentance = false;
            int count = 0;
            for (int i = - 26; i <= 26; i++)
            {
                var sentance = splitInput[count];
                char[] crackedSentance = new char[sentance.Length];
                for (int j = 0; j < sentance.Length; j++)
                {
                    crackedSentance[j] = crackingArray[sentance[j], i];
                }

                Console.WriteLine(new string(crackedSentance));
                if (!foundSensibleSentance)
                {
                    foundSensibleSentance = Console.ReadLine() != string.Empty;
                }

                if (foundSensibleSentance)
                {
                    if (count++ == splitInput.Length)
                    {
                        break;
                    }

                    i--;
                }
            }
        }
    }
}
