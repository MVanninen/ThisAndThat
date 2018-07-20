namespace MyTaskListUI
{
    using MyTaskList;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="MyTaskListUI" />
    /// </summary>
    public partial class MyTaskListUI : Form
    {
        /// <summary>
        /// Defines the CreateTaskButton
        /// </summary>
        private Button CreateTaskButton;

        /// <summary>
        /// Defines the QuitButton
        /// </summary>
        private Button QuitButton;

        /// <summary>
        /// Defines the buttonFlowLayout
        /// </summary>
        private FlowLayoutPanel buttonFlowLayout;

        /// <summary>
        /// Defines the MenuButtonsPanel
        /// </summary>
        private TableLayoutPanel MenuButtonsPanel;

        /// <summary>
        /// Defines the TasksView
        /// </summary>
        private DataGridView TasksView;

        /// <summary>
        /// Defines the taskListBindingSource
        /// </summary>
        private BindingSource taskListBindingSource;

        /// <summary>
        /// Defines the components
        /// </summary>
        private IContainer components;

        /// <summary>
        /// Defines the tasksBindingSource
        /// </summary>
        private BindingSource tasksBindingSource;

        /// <summary>
        /// Defines the Column1
        /// </summary>
        private DataGridViewTextBoxColumn Column1;

        /// <summary>
        /// Defines the Column2
        /// </summary>
        private DataGridViewTextBoxColumn Column2;

        /// <summary>
        /// Defines the Column3
        /// </summary>
        private DataGridViewTextBoxColumn Column3;

        /// <summary>
        /// Defines the Column4
        /// </summary>
        private DataGridViewCheckBoxColumn Column4;

        /// <summary>
        /// Defines the LoadListButton
        /// </summary>
        private Button LoadListButton;

        /// <summary>
        /// Defines the SaveListButton
        /// </summary>
        private Button SaveListButton;

        /// <summary>
        /// Defines the openFileDialog1
        /// </summary>
        private OpenFileDialog openFileDialog1;

        /// <summary>
        /// Defines the saveFileDialog1
        /// </summary>
        private SaveFileDialog saveFileDialog1;

        /// <summary>
        /// Defines the AllTasks
        /// </summary>
        private TaskList AllTasks = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTaskListUI"/> class.
        /// </summary>
        public MyTaskListUI()
        {
            InitializeComponent();

            if (AllTasks == null)
            {
                AllTasks = new TaskList();
            }
        }

        /// <summary>
        /// The MainWindow_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The InitializeComponent
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TasksView = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoadListButton = new System.Windows.Forms.Button();
            this.SaveListButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuButtonsPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButtonsPanel
            // 
            this.MenuButtonsPanel.ColumnCount = 2;
            this.MenuButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MenuButtonsPanel.Controls.Add(this.buttonFlowLayout, 0, 0);
            this.MenuButtonsPanel.Controls.Add(this.TasksView, 1, 0);
            this.MenuButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuButtonsPanel.Name = "MenuButtonsPanel";
            this.MenuButtonsPanel.RowCount = 1;
            this.MenuButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuButtonsPanel.Size = new System.Drawing.Size(674, 392);
            this.MenuButtonsPanel.TabIndex = 0;
            this.MenuButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuButtonsPanel_Paint);
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.LoadListButton);
            this.buttonFlowLayout.Controls.Add(this.SaveListButton);
            this.buttonFlowLayout.Controls.Add(this.CreateTaskButton);
            this.buttonFlowLayout.Controls.Add(this.QuitButton);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(162, 386);
            this.buttonFlowLayout.TabIndex = 5;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Location = new System.Drawing.Point(3, 61);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(137, 23);
            this.CreateTaskButton.TabIndex = 1;
            this.CreateTaskButton.Text = "Create a New Task";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(3, 90);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(137, 23);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TasksView
            // 
            this.TasksView.AutoGenerateColumns = false;
            this.TasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.TasksView.DataSource = this.tasksBindingSource;
            this.TasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksView.Location = new System.Drawing.Point(171, 3);
            this.TasksView.Name = "TasksView";
            this.TasksView.RowTemplate.Height = 24;
            this.TasksView.Size = new System.Drawing.Size(500, 386);
            this.TasksView.TabIndex = 6;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.taskListBindingSource;
            // 
            // taskListBindingSource
            // 
            this.taskListBindingSource.DataSource = typeof(MyTaskList.TaskList);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DueDate";
            this.Column3.HeaderText = "Due date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Done";
            this.Column4.HeaderText = "Done";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LoadListButton
            // 
            this.LoadListButton.Location = new System.Drawing.Point(3, 3);
            this.LoadListButton.Name = "LoadListButton";
            this.LoadListButton.Size = new System.Drawing.Size(137, 23);
            this.LoadListButton.TabIndex = 4;
            this.LoadListButton.Text = "Load Task List";
            this.LoadListButton.UseVisualStyleBackColor = true;
            this.LoadListButton.Click += new System.EventHandler(this.LoadListButton_Click);
            // 
            // SaveListButton
            // 
            this.SaveListButton.Location = new System.Drawing.Point(3, 32);
            this.SaveListButton.Name = "SaveListButton";
            this.SaveListButton.Size = new System.Drawing.Size(137, 23);
            this.SaveListButton.TabIndex = 5;
            this.SaveListButton.Text = "Save Task List";
            this.SaveListButton.UseVisualStyleBackColor = true;
            this.SaveListButton.Click += new System.EventHandler(this.SaveListButton_Click);
            // 
            // MyTaskListUI
            // 
            this.ClientSize = new System.Drawing.Size(674, 392);
            this.Controls.Add(this.MenuButtonsPanel);
            this.Name = "MyTaskListUI";
            this.Text = "MyTaskList";
            this.MenuButtonsPanel.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        /// <summary>
        /// The MenuButtonsPanel_Paint
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="PaintEventArgs"/></param>
        private void MenuButtonsPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// The CreateTaskButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskDialog taskInformation = new AddTaskDialog();
            DialogResult result = taskInformation.ShowDialog();

            if (result == DialogResult.OK)
            {
                AllTasks.CreateTask(taskInformation.Title, taskInformation.Description,
                    taskInformation.DueDate, taskInformation.Done);
                RefreshTaskView();
            }
        }

        /// <summary>
        /// The QuitButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The LoadListButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void LoadListButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var lines = File.ReadLines(openFileDialog1.FileName);

                foreach (string line in lines)
                {
                    string[] csvLine = line.Split(';');
                    AllTasks.CreateTask(csvLine[0], csvLine[1],
                    Convert.ToDateTime(csvLine[2]), Convert.ToBoolean(csvLine[3]));
                }

                RefreshTaskView();
            }
        }

        /// <summary>
        /// The SaveListButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void SaveListButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV file|*.csv";
            saveFileDialog1.Title = "Save a CSV File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (TextWriter tw = new StreamWriter(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < AllTasks.GetTaskListLenght(); i++)
                    {
                        MyTaskList.Task task = AllTasks.GetTaskData(i);
                        tw.WriteLine(string.Format("{0};{1};{2};{3}", task.Title, task.Description, task.DueDate.ToLongDateString(), task.Done.ToString()));
                    };
                }
            }
        }

        /// <summary>
        /// The RefreshTaskView
        /// </summary>
        private void RefreshTaskView()
        {
            // Use a proxy to get the data to show in the GridView, little clunky though
            BindingSource Source = new BindingSource();
            for (int i = 0; i < AllTasks.GetTaskListLenght(); i++)
            {
                Source.Add(AllTasks.GetTaskData(i));
            };
            TasksView.DataSource = Source;
        }
    }
}
