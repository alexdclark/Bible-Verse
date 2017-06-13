using System;
using System.Xml;

namespace BibleVerse2._0
{


    class GetScripture
    {
        String URLString1 = "http://labs.bible.org/api/?passage=";
        String URLString2 = "&type=xml";
        String scriptureResult;
        String scriptureContainer;
        String referenceContainer;
        String verseContainer;

        public string prepareScripture (string input)
        {
            String URLStringFinal = URLString1 + input + URLString2;

           scriptureResult =  getScripture(URLStringFinal);

            Console.WriteLine(URLStringFinal);

            return scriptureResult;
        }

        string getScripture (string XMLURL)
        {
            int count = 0;

            XmlTextReader reader = new XmlTextReader(XMLURL);

            while (reader.Read())
            {
                Console.WriteLine(count + reader.Value);
                if (count == 4)
                {
                    referenceContainer = reader.Value;

                }

               

                if (count == 17)
                {

                    //Fix me so I can ask for multiple verses. What is the common thread in the verses in the XML? 
                    //Verses are contained in a "Text" XML tag. How did I pull this off before?
                    
                    verseContainer = reader.Value;
                    
                }

                count++;
                
                

            }


            scriptureContainer = verseContainer + "\n" + referenceContainer;

            Console.WriteLine("Bible Verse: " + scriptureContainer);
            return scriptureContainer;


           
        }



    }
}
