namespace todo_list_winforms
{
    partial class TodoNoteView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            todo_dataGrid = new DataGridView();
            isDoneDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            todoNoteBindingSource = new BindingSource(components);
            title_label = new Label();
            title_textBox = new TextBox();
            description_textBox = new TextBox();
            description_label = new Label();
            create_button = new Button();
            save_button = new Button();
            delete_button = new Button();
            contextBindingSource = new BindingSource(components);
            contextBindingSource1 = new BindingSource(components);
            deadline_label = new Label();
            deadline_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)todo_dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)todoNoteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // todo_dataGrid
            // 
            todo_dataGrid.AutoGenerateColumns = false;
            todo_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todo_dataGrid.BackgroundColor = SystemColors.Control;
            todo_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todo_dataGrid.Columns.AddRange(new DataGridViewColumn[] { isDoneDataGridViewCheckBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            todo_dataGrid.DataSource = todoNoteBindingSource;
            todo_dataGrid.GridColor = SystemColors.ButtonShadow;
            todo_dataGrid.Location = new Point(12, 297);
            todo_dataGrid.Name = "todo_dataGrid";
            todo_dataGrid.RowTemplate.Height = 25;
            todo_dataGrid.Size = new Size(776, 270);
            todo_dataGrid.TabIndex = 0;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
            isDoneDataGridViewCheckBoxColumn.HeaderText = "IsDone";
            isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // todoNoteBindingSource
            // 
            todoNoteBindingSource.DataSource = typeof(DAL.Models.TodoNote);
            // 
            // title_label
            // 
            title_label.Location = new Point(12, 6);
            title_label.Name = "title_label";
            title_label.Size = new Size(159, 18);
            title_label.TabIndex = 1;
            title_label.Text = "Задача";
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(12, 25);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(776, 23);
            title_textBox.TabIndex = 2;
            // 
            // description_textBox
            // 
            description_textBox.Location = new Point(12, 73);
            description_textBox.Name = "description_textBox";
            description_textBox.Size = new Size(776, 23);
            description_textBox.TabIndex = 3;
            // 
            // description_label
            // 
            description_label.Location = new Point(12, 53);
            description_label.Name = "description_label";
            description_label.Size = new Size(776, 19);
            description_label.TabIndex = 1;
            description_label.Text = "Описание";
            // 
            // create_button
            // 
            create_button.Location = new Point(12, 159);
            create_button.Name = "create_button";
            create_button.Size = new Size(129, 25);
            create_button.TabIndex = 4;
            create_button.Text = "Новая задача";
            create_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            save_button.Location = new Point(659, 159);
            save_button.Name = "save_button";
            save_button.Size = new Size(129, 25);
            save_button.TabIndex = 4;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(525, 159);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(129, 25);
            delete_button.TabIndex = 4;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            // 
            // contextBindingSource
            // 
            contextBindingSource.DataSource = typeof(DAL.Context);
            // 
            // contextBindingSource1
            // 
            contextBindingSource1.DataSource = typeof(DAL.Context);
            // 
            // deadline_label
            // 
            deadline_label.Location = new Point(12, 99);
            deadline_label.Name = "deadline_label";
            deadline_label.Size = new Size(776, 19);
            deadline_label.TabIndex = 1;
            deadline_label.Text = "Крайний срок";
            // 
            // deadline_textBox
            // 
            deadline_textBox.Location = new Point(12, 119);
            deadline_textBox.Name = "deadline_textBox";
            deadline_textBox.Size = new Size(776, 23);
            deadline_textBox.TabIndex = 3;
            // 
            // TodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(delete_button);
            Controls.Add(save_button);
            Controls.Add(create_button);
            Controls.Add(deadline_textBox);
            Controls.Add(description_textBox);
            Controls.Add(title_textBox);
            Controls.Add(deadline_label);
            Controls.Add(description_label);
            Controls.Add(title_label);
            Controls.Add(todo_dataGrid);
            Name = "TodoList";
            Text = "Список задач";
            ((System.ComponentModel.ISupportInitialize)todo_dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)todoNoteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView todo_dataGrid;
        private Label title_label;
        private TextBox title_textBox;
        private TextBox description_textBox;
        private Label description_label;
        private Button create_button;
        private Button save_button;
        private Button delete_button;
        private DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource todoNoteBindingSource;
        private BindingSource contextBindingSource;
        private BindingSource contextBindingSource1;
        private Label deadline_label;
        private TextBox deadline_textBox;
    }
}
