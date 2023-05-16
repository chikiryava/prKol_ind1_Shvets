
namespace pract16_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsList = new System.Windows.Forms.ListView();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAndSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsList
            // 
            this.studentsList.GridLines = true;
            this.studentsList.HideSelection = false;
            this.studentsList.Location = new System.Drawing.Point(123, 12);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(467, 182);
            this.studentsList.TabIndex = 0;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            this.studentsList.View = System.Windows.Forms.View.List;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(303, 273);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите имя файла";
            // 
            // showAndSortButton
            // 
            this.showAndSortButton.Location = new System.Drawing.Point(289, 299);
            this.showAndSortButton.Name = "showAndSortButton";
            this.showAndSortButton.Size = new System.Drawing.Size(136, 53);
            this.showAndSortButton.TabIndex = 3;
            this.showAndSortButton.Text = "Вывести и отсортировать учеников";
            this.showAndSortButton.UseVisualStyleBackColor = true;
            this.showAndSortButton.Click += new System.EventHandler(this.showAndSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAndSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.studentsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentsList;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAndSortButton;
    }
}

