namespace MyTaskListUI
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="AddTaskDialog" />
    /// </summary>
    public partial class AddTaskDialog : Form
    {
        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the DueDate
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Done
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTaskDialog"/> class.
        /// </summary>
        public AddTaskDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The tableLayoutPanel1_Paint
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="PaintEventArgs"/></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Title = textBox1.Text;
            Description = textBox2.Text;
            DueDate = dateTimePicker1.Value;
            Done = checkBox1.Checked;
            Close();
        }
    }
}
