using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BibleVerse2._0
{
    public partial class Form1 : Form
       
        
    {
        String input;
        String Output;
        public Form1()
        {
            InitializeComponent();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Getting a Bible Verse";
            GetScripture Bible = new GetScripture();
            input = bookInput.Text + "%20"+ chapterBox.Text +":" + verseBox.Text;
            
            Output = Bible.prepareScripture(input);
            button1.Text = "Find a new Verse";
            textBox1.Text = Output;

        }
    }
}
