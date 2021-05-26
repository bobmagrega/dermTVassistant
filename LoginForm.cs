using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExampleSQLapp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void KMNDOTS_Click(object sender, EventArgs e)
        {
            string docName;
            docName = docInput.Text;
            docResult.Text = "к.м.н., доц. " + docName;
            Clipboard.SetText(docResult.Text);
        }

        private void DMNPROF_Click(object sender, EventArgs e)
        {
            string docName;
            docName = docInput.Text;
            docResult.Text = "д.м.н., проф. " + docName;
            Clipboard.SetText(docResult.Text);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            var docNames = File.ReadAllLines("test.txt");
            string query;
            query = searchBox.Text;

            if (string.IsNullOrEmpty(query))
            {
                
                searchResult.Text = "Ничего не найдено";
                return;
            }


            else if (query.Contains("."))
            { query = query; }



            else { query = char.ToUpper(query[0]) + query.Substring(1); }


            var search = from x in docNames
                         where x.Contains(query)
                         select x;


            foreach (string s in search)
            {
                searchResult.AppendText(s);
                searchResult.AppendText(Environment.NewLine);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                searchButton_Click(searchButton, null);
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDoc3.Text = "к.м.н., доц. ";
            addDoc3.Focus();
            if (!string.IsNullOrEmpty(addDoc3.Text)) addDoc3.Select(14, 14);
        }

        private void addDMNbtn_Click(object sender, EventArgs e)
        {
            addDoc3.Text = "д.м.н., проф. ";
            addDoc3.Focus();
            if (!string.IsNullOrEmpty(addDoc3.Text)) addDoc3.Select(14, 14);

        }

        private void addDocbtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
           
                
                string add1 = addDoc1.Text;
            if (string.IsNullOrEmpty(add1))
            {
                addDoc1.Text = "Не были введены данные.";

            }
           
            else if (addDoc1.Text == "Не были введены данные.")
            {
                add1 = null;
            }




            else
            {
                list.Add(add1);
                File.AppendAllText("test.txt", "\n" + add1);
            }

            string add2 = addDoc2.Text;
            if (string.IsNullOrEmpty(add2))
            {
                addDoc2.Text = "Не были введены данные.";

            }

            else if (addDoc2.Text == "Не были введены данные.")
            {
                add2 = null;
            }

            else
            {
                list.Add(add1);
                File.AppendAllText("test.txt", "\n" + add2);
            }

            string add3 = addDoc3.Text;
            if (string.IsNullOrEmpty(add3))
            {
                addDoc3.Text = "Не были введены данные.";

            }

            else if (addDoc3.Text == "д.м.н., проф. ")
            {
                addDoc3.Text = "Не были введены данные.";

            }

            else if (addDoc3.Text == "к.м.н., доц. ")
            {
                addDoc3.Text = "Не были введены данные.";
            }

            else if (addDoc3.Text == "Не были введены данные.")
            {
                add3 = null;
            }



            else
            {
                list.Add(add3);
                File.AppendAllText("test.txt", "\n" + add3);
            }

            searchResult.Clear();

            if (string.IsNullOrEmpty(add1) && string.IsNullOrEmpty(add2) && string.IsNullOrEmpty(add3))
            {
                searchResult.AppendText("Ничего не было добавлено.");
            }

           else if (string.IsNullOrEmpty(add1) && string.IsNullOrEmpty(add2) && add3 == "д.м.н., проф. ")
            {
                addDoc3.Text = "Не были введены данные.";
                searchResult.AppendText("Ничего не было добавлено.");
            }

            else if (string.IsNullOrEmpty(add1) && string.IsNullOrEmpty(add2) && add3 == "к.м.н., доц. ")
            {
                addDoc3.Text = "Не были введены данные.";
                searchResult.AppendText("Ничего не было добавлено.");
            }


            else if (add1 == "Не были введены данные." && add2 == "Не были введены данные." && add3 == "Не были введены данные.")
            {
                add1 = null;
                add2 = null;
                add3 = null;

                searchResult.AppendText("Ничего не было добавлено.");
            }



            else {
                searchResult.AppendText("Добавлено:");
                searchResult.AppendText(Environment.NewLine);
                searchResult.AppendText(add1);
                searchResult.AppendText(Environment.NewLine);
                searchResult.AppendText(add2);
                searchResult.AppendText(Environment.NewLine);
                searchResult.AppendText(add3);
                searchResult.AppendText(Environment.NewLine);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            addDoc1.Clear();
            addDoc2.Clear();
            addDoc3.Clear();
            searchBox.Clear();
            docInput.Clear();
            searchResult.Text = "Список врачей";
            docResult.Clear();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("<br>");
        }

        

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            string[] separator = { "\n",};
            string[] pasta = File.ReadAllText("pasta.txt").Split(separator, StringSplitOptions.None);
            listBox1.Items.AddRange(pasta);
            listBox1.Items.Remove("");
            listBox1.Items.Remove("\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Remove("");
            File.AppendAllText("pasta.txt", textBox1.Text + "\n");
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string[] string_array = (from object item in listBox1.Items select item.ToString()).ToArray<string>();

            listBox1.Items.Remove("");
            File.WriteAllLines("pasta.txt", string_array);

            //foreach (string k in string_array)
            //{
                
            //}
            
            
        }







        //private void searchResult_TextChanged(object sender, EventArgs e)
        //{
        //    searchResult.Lines = File.ReadAllLines("test.txt");
        //}





        //private void searchBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == (char)Keys.Enter)
        //    {
        //        searchButton_Click(searchButton, null);
        //    }
        //}



        // void LoginForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == (char)Keys.Enter)
        //    {
        //        searchButton_Click(searchButton, null);
        //    }
        //}
    }
}