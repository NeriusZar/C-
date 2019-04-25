using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UI
{
    class ReadFiles
    {
        List<string> lines = new List<string>();

        public void ReadKeyFile(ref apiInfo apiInformation, string pathOneFile, string pathSecondFile = null)
        {
            ReadingWithStream(pathOneFile);
            if(pathSecondFile != null)
                ReadingWithStream(pathSecondFile);
                apiInformation.apiKey = lines[0];
                apiInformation.apiLoc = lines[1];        
        }

        private void ReadingWithStream(string path)
        {

            try
            {
            using (FileStream fsSource = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                   using (StreamReader sr = new StreamReader(fsSource))
                 {
                        string line = string.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line != string.Empty)
                            {
                                lines.Add(line);
                            }
                        }
                  }
                }

            }
            catch (FileNotFoundException ioEx)
            {
                    ErrorHandling.PrintError(ioEx);
            }
        }
    }
}
