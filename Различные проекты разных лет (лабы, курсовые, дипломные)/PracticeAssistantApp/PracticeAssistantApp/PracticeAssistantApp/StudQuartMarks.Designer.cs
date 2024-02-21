namespace PracticeAssistantApp
{
    partial class StudQuartMarks
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
            System.Windows.Forms.Label periodLabel;
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label subjectLabel;
            this.sourceDataSet = new PracticeAssistantApp.SourceDataSet();
            this.quartMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartMarksTableAdapter = new PracticeAssistantApp.SourceDataSetTableAdapters.QuartMarksTableAdapter();
            this.tableAdapterManager = new PracticeAssistantApp.SourceDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            periodLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceDataSet
            // 
            this.sourceDataSet.DataSetName = "SourceDataSet";
            this.sourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartMarksBindingSource
            // 
            this.quartMarksBindingSource.DataMember = "QuartMarks";
            this.quartMarksBindingSource.DataSource = this.sourceDataSet;
            // 
            // quartMarksTableAdapter
            // 
            this.quartMarksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuartMarksTableAdapter = this.quartMarksTableAdapter;
            this.tableAdapterManager.UpdateOrder = PracticeAssistantApp.SourceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new System.Drawing.Point(32, 97);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(48, 13);
            periodLabel.TabIndex = 9;
            periodLabel.Text = "Период:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(39, 160);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(48, 13);
            markLabel.TabIndex = 7;
            markLabel.Text = "Оценка:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(32, 132);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(55, 13);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Предмет:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.quartMarksBindingSource;
            this.comboBox1.DisplayMember = "Period";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Period";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(145, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(312, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Итоговые оценки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 60);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.quartMarksBindingSource;
            this.comboBox2.DisplayMember = "Subject";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "Subject";
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartMarksBindingSource, "Mark", true));
            this.markTextBox.Location = new System.Drawing.Point(126, 156);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(100, 20);
            this.markTextBox.TabIndex = 25;
            // 
            // StudQuartMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 252);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(markLabel);
            this.Controls.Add(periodLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudQuartMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudQuartMarks";
            this.Load += new System.EventHandler(this.StudQuartMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SourceDataSet sourceDataSet;
        private System.Windows.Forms.BindingSource quartMarksBindingSource;
        private SourceDataSetTableAdapters.QuartMarksTableAdapter quartMarksTableAdapter;
        private SourceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox markTextBox;
    }
}