
namespace ExampleSQLapp2
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.docInput = new System.Windows.Forms.TextBox();
            this.KMNDOTS = new System.Windows.Forms.Button();
            this.DMNPROF = new System.Windows.Forms.Button();
            this.docResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDoc1 = new System.Windows.Forms.TextBox();
            this.addDoc2 = new System.Windows.Forms.TextBox();
            this.addDoc3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addDocbtn = new System.Windows.Forms.Button();
            this.addKMNbtn = new System.Windows.Forms.Button();
            this.addDMNbtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.soundPastebtn = new System.Windows.Forms.Button();
            this.renamePastebtn = new System.Windows.Forms.Button();
            this.waitPastebtn = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя лектора в формате Фамилия И.О.:";
            // 
            // docInput
            // 
            this.docInput.Location = new System.Drawing.Point(15, 26);
            this.docInput.Name = "docInput";
            this.docInput.Size = new System.Drawing.Size(250, 20);
            this.docInput.TabIndex = 1;
            // 
            // KMNDOTS
            // 
            this.KMNDOTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KMNDOTS.Location = new System.Drawing.Point(15, 52);
            this.KMNDOTS.Name = "KMNDOTS";
            this.KMNDOTS.Size = new System.Drawing.Size(95, 35);
            this.KMNDOTS.TabIndex = 2;
            this.KMNDOTS.Text = "к.м.н., доц. ";
            this.KMNDOTS.UseVisualStyleBackColor = true;
            this.KMNDOTS.Click += new System.EventHandler(this.KMNDOTS_Click);
            // 
            // DMNPROF
            // 
            this.DMNPROF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMNPROF.Location = new System.Drawing.Point(170, 52);
            this.DMNPROF.Name = "DMNPROF";
            this.DMNPROF.Size = new System.Drawing.Size(95, 35);
            this.DMNPROF.TabIndex = 3;
            this.DMNPROF.Text = "д.м.н., проф. ";
            this.DMNPROF.UseVisualStyleBackColor = true;
            this.DMNPROF.Click += new System.EventHandler(this.DMNPROF_Click);
            // 
            // docResult
            // 
            this.docResult.Location = new System.Drawing.Point(15, 96);
            this.docResult.Name = "docResult";
            this.docResult.ReadOnly = true;
            this.docResult.Size = new System.Drawing.Size(250, 20);
            this.docResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск. Введите имя лектора:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(322, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(250, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(322, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 35);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Искать";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(322, 95);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.Size = new System.Drawing.Size(250, 317);
            this.searchResult.TabIndex = 8;
            this.searchResult.Text = "Список врачей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Заполните форму:";
            // 
            // addDoc1
            // 
            this.addDoc1.Location = new System.Drawing.Point(15, 155);
            this.addDoc1.Name = "addDoc1";
            this.addDoc1.Size = new System.Drawing.Size(250, 20);
            this.addDoc1.TabIndex = 10;
            // 
            // addDoc2
            // 
            this.addDoc2.Location = new System.Drawing.Point(15, 193);
            this.addDoc2.Name = "addDoc2";
            this.addDoc2.Size = new System.Drawing.Size(250, 20);
            this.addDoc2.TabIndex = 11;
            // 
            // addDoc3
            // 
            this.addDoc3.Location = new System.Drawing.Point(15, 232);
            this.addDoc3.Name = "addDoc3";
            this.addDoc3.Size = new System.Drawing.Size(250, 20);
            this.addDoc3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пример: Иванов Иван Иванович";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Пример: Иванову И.И.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пример: д.м.н., проф. Иванов И.И.";
            // 
            // addDocbtn
            // 
            this.addDocbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDocbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDocbtn.Location = new System.Drawing.Point(12, 283);
            this.addDocbtn.Name = "addDocbtn";
            this.addDocbtn.Size = new System.Drawing.Size(95, 35);
            this.addDocbtn.TabIndex = 16;
            this.addDocbtn.Text = "Добавить";
            this.addDocbtn.UseVisualStyleBackColor = true;
            this.addDocbtn.Click += new System.EventHandler(this.addDocbtn_Click);
            // 
            // addKMNbtn
            // 
            this.addKMNbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKMNbtn.Location = new System.Drawing.Point(113, 283);
            this.addKMNbtn.Name = "addKMNbtn";
            this.addKMNbtn.Size = new System.Drawing.Size(95, 35);
            this.addKMNbtn.TabIndex = 17;
            this.addKMNbtn.Text = "к.м.н., доц. ";
            this.addKMNbtn.UseVisualStyleBackColor = true;
            this.addKMNbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addDMNbtn
            // 
            this.addDMNbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDMNbtn.Location = new System.Drawing.Point(214, 283);
            this.addDMNbtn.Name = "addDMNbtn";
            this.addDMNbtn.Size = new System.Drawing.Size(95, 35);
            this.addDMNbtn.TabIndex = 18;
            this.addDMNbtn.Text = "д.м.н., проф. ";
            this.addDMNbtn.UseVisualStyleBackColor = true;
            this.addDMNbtn.Click += new System.EventHandler(this.addDMNbtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(12, 377);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(95, 35);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // soundPastebtn
            // 
            this.soundPastebtn.Location = new System.Drawing.Point(610, 334);
            this.soundPastebtn.Name = "soundPastebtn";
            this.soundPastebtn.Size = new System.Drawing.Size(105, 36);
            this.soundPastebtn.TabIndex = 20;
            this.soundPastebtn.Text = "Звук";
            this.soundPastebtn.UseVisualStyleBackColor = true;
            this.soundPastebtn.Click += new System.EventHandler(this.soundPastebtn_Click);
            // 
            // renamePastebtn
            // 
            this.renamePastebtn.Location = new System.Drawing.Point(610, 292);
            this.renamePastebtn.Name = "renamePastebtn";
            this.renamePastebtn.Size = new System.Drawing.Size(105, 36);
            this.renamePastebtn.TabIndex = 21;
            this.renamePastebtn.Text = "Переименование";
            this.renamePastebtn.UseVisualStyleBackColor = true;
            this.renamePastebtn.Click += new System.EventHandler(this.renamePastebtn_Click);
            // 
            // waitPastebtn
            // 
            this.waitPastebtn.Location = new System.Drawing.Point(610, 376);
            this.waitPastebtn.Name = "waitPastebtn";
            this.waitPastebtn.Size = new System.Drawing.Size(105, 36);
            this.waitPastebtn.TabIndex = 22;
            this.waitPastebtn.Text = "Ожидание входа";
            this.waitPastebtn.UseVisualStyleBackColor = true;
            this.waitPastebtn.Click += new System.EventHandler(this.waitPastebtn_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Копипасты:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.waitPastebtn);
            this.Controls.Add(this.renamePastebtn);
            this.Controls.Add(this.soundPastebtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.addDMNbtn);
            this.Controls.Add(this.addKMNbtn);
            this.Controls.Add(this.addDocbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addDoc3);
            this.Controls.Add(this.addDoc2);
            this.Controls.Add(this.addDoc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.docResult);
            this.Controls.Add(this.DMNPROF);
            this.Controls.Add(this.KMNDOTS);
            this.Controls.Add(this.docInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "dermatology.ru assistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox docInput;
        private System.Windows.Forms.Button KMNDOTS;
        private System.Windows.Forms.Button DMNPROF;
        private System.Windows.Forms.TextBox docResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addDoc1;
        private System.Windows.Forms.TextBox addDoc2;
        private System.Windows.Forms.TextBox addDoc3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addDocbtn;
        private System.Windows.Forms.Button addKMNbtn;
        private System.Windows.Forms.Button addDMNbtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button soundPastebtn;
        private System.Windows.Forms.Button renamePastebtn;
        private System.Windows.Forms.Button waitPastebtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}