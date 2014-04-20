using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyClicker
{
    class Reader
    {
        String filePath;
        String lineRead;

        DialogBox dialog;

        int mouseX;
        int mouseY;
        int key_code;
        int line = 0;

        System.IO.StreamReader streamReader;
        StringBuilder sb;

        public Reader(String filePath)
        {
            this.filePath = filePath;

            dialog = new DialogBox();
            sb = new StringBuilder(lineRead);

            try
            {
                streamReader = new System.IO.StreamReader(filePath);
            }catch(Exception){
                dialog.Show();
                dialog.setTitle("Warning");
                dialog.sendError("File Not Found");
            }
        }

        public void start()
        {
            line = 0;
            
            while(!streamReader.EndOfStream){
                lineRead = streamReader.ReadToEnd();
                
                line++;
            }
            Char[] lineChars = new Char[lineRead.Length];

            for (int i = 0; i < lineChars.Length; i++ )
            {
                lineChars[i] = lineRead[i];
            }

            if (lineChars.Length > 0)
            {
                for (int i = 0; i < lineChars.Length; i++)
                {
                    if (lineChars[i].Equals('#'))
                    {
                        lineChars[i] = ' ';
                        for (int j = i; j < lineChars.Length; j++)
                        {
                            if(!lineChars[j].Equals('/')){
                                lineChars[j] = ' ';
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if(lineChars[i].Equals(';')){

                    }
                }
            }
            lineRead = new String(lineChars);
        }

        public void stop()
        {
            streamReader.Close();
            streamReader.Dispose();
        }
        public String getOut()
        {
            return this.lineRead;
        }
        public int getLine()
        {
            return this.line;
        }
        public int getKeyCode()
        {
            return this.key_code;
        }
        public int getMouseX()
        {
            return this.mouseX;
        }
        public int getMouseY()
        {
            return this.mouseY;
        }
    }
}
