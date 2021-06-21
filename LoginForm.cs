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
            addDoc3.Text = "к.м.н., доц. " + addDoc2.Text;
            addDoc3.Focus();
            if (!string.IsNullOrEmpty(addDoc3.Text)) addDoc3.Select(14, 14);
        }

        private void addDMNbtn_Click(object sender, EventArgs e)
        {
            addDoc3.Text = "д.м.н., проф. " + addDoc2.Text;
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



            else
            {
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

        private void renamePastebtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Чтобы переименовать себя, нажмите на кнопку \"участники\" внизу в программе зум.\nВ верху списка имен будете вы, в скобочках будет написано(я).\nНажмите по себе и выберите \"переименовать\".Введите ваши ФИО.\nУчастники, не указавшие своё имя, будут переведены в зал ожидания без возможности просмотра лекции до установления личности.");
        }

        private void soundPastebtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Для тех, у кого нет звука: В левом нижнем углу программы зум есть кнопка с иконкой микрофончика.\nНажмите по ней и следуйте инструкциям на экране. На компьютерах появится синяя кнопка \"использовать звук компьютера\" - нажмитей по ней, чтобы включить звук.\nНа мобильных устройствах может быть кнопка \"Wi - Fi или отправка данных сотовой сети\", нажмите по ней, чтобы включить звук.");
        }

        private void waitPastebtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Пользователи, которые ожидают разрешение на вход от организатора - вам нужно изменить имя в зум, по которому мы сможем узнать вас.\nПока вы не переименуетесь или не напишите в группу вацап ваше ФИО, вас не допустят до лекции.");
        }
    }
}