using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        class dec
        {
            public string id;
            public string var;
            public string op;
            public string sym;
        }
        List<dec> decs = new List<dec>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = Texteditor.Text;
            
            for(int i=0;i<word.Length;i++)
            {
                if(word[i]=='i' && word[i+1]=='n'&&word[i+2]=='t')
                {
                    if (word[i + 3].ToString() == " ")
                    {
                        if(word[i + 4]>='a' && word[i + 4] <= 'z')
                        {
                            if (word[i + 5] == '=')
                            {
                                while (word[i + 6] != ';')
                                {

                                }
                               /* if (word[i + 6] >= -100000)
                                {
                                    
                                   if(word[i+7]==';')
                                    {
                                        MessageBox.Show("gg");
                                        break;
                                    }
                                   else if(word[i + 7]=='+'|| word[i + 7]=='-'|| word[i + 7]=='*'|| word[i + 7]=='/')
                                    {
                                       }
                                  */  
                                }
                            }
                        }
                    }
                }
             
            }
        }
    }
}
