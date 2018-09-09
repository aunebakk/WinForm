using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RealGrid {
    public partial class EnumsAndComboBox : Form {
        private BindingSource bindingSource = new BindingSource();
        public TaskStatus[] taskStatus { get; set; }

        public EnumsAndComboBox() {
            // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-objects-to-windows-forms-datagridview-controls
            InitializeComponent();

            // Populate the data source.
            taskStatus = new TaskStatus[(int)TaskNorClientLightNew.Last+1];
            foreach (TaskNorClientLightNew task in Enum.GetValues(typeof(TaskNorClientLightNew))) {
                //bindingSource.Add(new TaskStatus { Number = (int) task, Task = task, TaskName = Program.UpperAddSpace(task.ToString()), TaskStart = DateTime.UtcNow });
                taskStatus[(int)task] = new TaskStatus { Number = (int) task, Task = task, TaskName = Program.UpperAddSpace(task.ToString()), TaskStart = DateTime.UtcNow };
                bindingSource.Add(taskStatus[(int)task]);
            }

            // Initialize the DataGridView.
            InitializeDarkGrid(dataGridView);
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = bindingSource;

            foreach (DataGridViewColumn column in dataGridView.Columns)
                column.HeaderText = Program.UpperAddSpace(column.DataPropertyName);

            dataGridView.Columns["Number"].HeaderText = "Start";
            dataGridView.Columns["TaskStart"].HeaderText = "Start";
            dataGridView.Columns["TaskEnd"].HeaderText = "End";
            dataGridView.Columns["DurationInSeconds"].HeaderText = "Duration";
            dataGridView.Columns["TotalMinutes"].HeaderText = "Total";
            dataGridView.Columns["LogCount"].HeaderText = "Log";
            dataGridView.Columns["ErrorCount"].HeaderText = "Error";
            dataGridView.Columns["ErrorTolerance"].HeaderText = "Tolerance";
            dataGridView.Columns["TaskLink"].HeaderText = "Link";
        }

        private void buttonSelectTest_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridView.Rows) {
                row.DefaultCellStyle.BackColor = LogFilterColorHighlight;
                row.DefaultCellStyle.ForeColor = LogFilterColorWhiteSoft;
            }
        }

        private void buttonSelectTest2_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridView.Rows) {
                row.DefaultCellStyle.BackColor = LogFilterColorDark;
                row.DefaultCellStyle.ForeColor = LogFilterColorWhiteSoft;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e) {
            foreach (TaskStatus x in taskStatus) {
                x.DoneFlag = !x.DoneFlag;
            }

            dataGridView.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        void InitializeDarkGrid(
            DataGridView dataGridView
            ) {

            dataGridView.RowTemplate.Height = 20;

            // need to do this as moving the form/code to a different environment somehow looses the vertical setting
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.ScrollBars = ScrollBars.Both;
            //dataGridView.Dock = DockStyle.Fill;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // colors
            dataGridView.DefaultCellStyle.BackColor = LogFilterColorDarkDark;
            dataGridView.ForeColor = LogFilterColorWhiteSoft;

            dataGridView.DefaultCellStyle.SelectionBackColor = LogFilterColorHighlight;
            dataGridView.DefaultCellStyle.SelectionForeColor = LogFilterColorWhiteSoft;

            // alternate colors
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = LogFilterColorDarkDark;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = LogFilterColorWhiteSoft;

            // clear grid
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = false;

            // check each column
            dataGridView.AutoGenerateColumns = true;

            // allow editing of description
            dataGridView.Refresh();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoResizeColumns();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
        }

        public static Color LogFilterColorDarkDark { get { return System.Drawing.Color.FromArgb(030, 30, 30); } }
        public static Color LogFilterColorDark { get { return System.Drawing.Color.FromArgb(40, 40, 40); } }
        public static Color LogFilterColorErrorInLog { get { return System.Drawing.Color.FromArgb(21, 132 - 10, 251); } }
        public static Color LogFilterColorHighlight { get { return System.Drawing.Color.FromArgb(21, 132, 251); } }
        public static Color LogFilterColorHighlightTotal { get { return System.Drawing.Color.FromArgb(21, 132 - 20, 251); } }
        public static Color LogFilterColorException { get { return System.Drawing.Color.FromArgb(21, 132, 251); } }
        public static Color LogFilterColorFailure { get { return System.Drawing.Color.FromArgb(21, 132, 251); } }
        public static Color LogFilterColorWhite { get { return Color.White; } }
        public static Color LogFilterColorWhiteSoft { get { return Color.WhiteSmoke; } }
        public static Color LogFilterColorLink { get { return System.Drawing.Color.FromArgb(131, 186, 196); } }
        public static Color LogFilterColorLinkVisited { get { return Color.NavajoWhite; } }
    }
}