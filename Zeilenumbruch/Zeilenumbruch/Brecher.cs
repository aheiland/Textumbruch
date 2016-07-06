using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Textänderung ;-)
<<<<<<< HEAD
//Text...
=======
//Textänderung 2 ;-)
>>>>>>> be566019b45d113d7169269608ffb7757e64a26b
namespace Zeilenumbruch
{
    public class Brecher
    {
        public string Text { get; set; }
        public bool IsNotNull { get; set; }
        public int j { get; set; }
        public Brecher(String text) 
        {              
				IsNotNull = (text != null);
				IsNotNull ? Text = text : Text = String.Empty;
		
        }
        public string Umbrechen(int laenge) 
        {
            String nachher = Text;
            for (int i = 0; i <= nachher.Length; i += laenge)
            {
                while (i >= 1)
                {
                    if (nachher[i] != ' ')
                    {
                        while (nachher[i] != ' ')
                        {
                            j++;
                            if (j > laenge)
                            {
                                break;
                            }                         
                            i--;                               
                        }
                        if (j > laenge)
                        {
                            i += laenge;
                            while (nachher[i] != ' ')
                            {
                                i++;
                                if (i >= nachher.Length)
                                {
                                    return nachher;
                                }
                            }
                        }                     
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (i != 0)
                {
                    nachher = nachher.Insert((++i), "\n");
                    j = 0;
                }
            }        
            return nachher;
        }
    }
}
