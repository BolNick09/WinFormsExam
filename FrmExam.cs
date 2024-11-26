using Microsoft.Identity.Client;
using System.DirectoryServices.ActiveDirectory;
using WinFormsExam;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace FrmExam
{
    public partial class FrmExam : Form
    {
        public List<TaskObject> taskObjects { get; set; }
        public List<WinFormsExam.Task> tasks { get; set; }
        public List<Decision> decisions { get; set; }
        public List<User> users { get; set; }

        public TaskObject SelectedTaskObject { get; set; }
        public WinFormsExam.Task SelectedTask { get; set; }
        public Decision SelectedDecision { get; set; }
        public User SelectedUser { get; set; }

        public FrmExam()
        {
            InitializeComponent();
            taskObjects = new();
            tasks = new();
            decisions = new();
            users = new();

        }

        private void ShowMessage(Color colour, string message)
        {
            lblMessage.ForeColor = colour;
            lblMessage.Text = message;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvMain.SelectedNode == null)
                return;

            if (tvMain.SelectedNode.Parent == null)
            {
                SelectedTaskObject = taskObjects.FirstOrDefault(t => t.Id == (int)tvMain.SelectedNode.Tag); //(TaskObject)tvMain.SelectedNode.Tag;
                SelectedTask = null;
                SelectedDecision = null;
                SelectedUser = null;
            }
            else
            {
                SelectedTaskObject = taskObjects.FirstOrDefault(t => t.Id == (int)tvMain.SelectedNode.Parent.Tag);
                SelectedTask = tasks.FirstOrDefault(t => t.Id == (int)tvMain.SelectedNode.Tag);

                SelectedDecision = decisions.FirstOrDefault(t => t.Id == SelectedTask.DecisionId);
                SelectedUser = users.FirstOrDefault(t => t.Id == SelectedTask.UserId);
            }
            clearAll();
            lblObjectId.Text = SelectedTaskObject?.Id.ToString() ?? "0";
            tbObjectName.Text = SelectedTaskObject?.Name ?? "";
            tbAddress.Text = SelectedTaskObject?.Address ?? "";
            tbCadastralNumber.Text = SelectedTaskObject?.CadastralNumber ?? "";
            lblTasksCount.Text = SelectedTaskObject?.TasksID?.Count.ToString() ?? "0";

            if (SelectedTask != null)
            {
                lblTaskId.Text = SelectedTask.Id.ToString();
                lblDecisionId.Text = SelectedDecision?.Id.ToString();
                lblPersonId.Text = SelectedUser?.Id.ToString();

                tbTaskDescription.Text = SelectedTask.TaskDescription;
                tbDecisionDescription.Text = SelectedDecision?.DecisionDescription;
                tbStartDate.Text = SelectedDecision?.StartDate.ToString();
                tbEndDate.Text = SelectedDecision?.EndDate.ToString();

                tbPersonName.Text = SelectedUser?.Username;
                //cbbStatus.Text = SelectedTask.Status;
                //cbbPosition.Text = SelectedUser?.Position;
            }

        }

        private void tbCadastralNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmExam_Load(object sender, EventArgs e)
        {
            clearAll();
            tvMain.Nodes.Clear();
            lblCount.Text = "0";

            TaskObject.GetInfo(taskObjects);
            WinFormsExam.Task.GetInfo(tasks);
            Decision.GetInfo(decisions);
            User.GetInfo(users);

            fillTvMain();

            ShowMessage(Color.Green, "������ ���������.");
        }

        private void clearAll()
        {
            lblTasksCount.Text = "0";

            lblObjectId.Text = "";
            lblTaskId.Text = "";
            lblDecisionId.Text = "";
            lblPersonId.Text = "";

            lblMessage.Text = "";

            tbObjectName.Text = "";
            tbAddress.Text = "";
            tbCadastralNumber.Text = "";

            tbTaskDescription.Text = "";
            tbDecisionDescription.Text = "";

            tbStartDate.Text = "";
            tbEndDate.Text = "";

            cbbStatus.Items.Clear();
            cbbPosition.Items.Clear();
        }

        private void fillTvMain()
        {
            tvMain.Nodes.Clear();

            foreach (TaskObject taskObject in taskObjects)
            {
                var taskObjectNode = tvMain.Nodes.Add(taskObject.Id.ToString(), taskObject.Name);
                taskObjectNode.Tag = taskObject.Id;
                taskObjectNode.ImageIndex = 0;
                taskObjectNode.Text = taskObject.Name;

                List<string> tasksIds = taskObject.TasksID.Select(t => t.ToString()).ToList();
                List<WinFormsExam.Task> childTasks = tasks.Where(t => tasksIds.Contains(t.Id.ToString())).ToList();

                foreach (WinFormsExam.Task task in childTasks)
                {
                    var taskNode = taskObjectNode.Nodes.Add(task.Id.ToString(), task.TaskDescription);
                    taskNode.Tag = task.Id;
                    taskNode.ImageIndex = 1;
                    taskNode.Text = task.TaskDescription;
                }
            }
            lblCount.Text = tvMain.GetNodeCount(false).ToString();
        }

        private bool CheckTaskObject()
        {
            if (tbObjectName.Text.IsNullOrEmpty())
                return false;
            if (tbAddress.Text.IsNullOrEmpty())
                return false;
            if (tbCadastralNumber.Text.IsNullOrEmpty())
                return false;

            return true;
        }
        private void AddTaskObject()
        {
            if (!CheckTaskObject())
            {
                ShowMessage(Color.Red, "��������� ��� ���� �������");
                return;
            }

            TaskObject taskObject = new TaskObject(tbObjectName.Text, tbAddress.Text, tbCadastralNumber.Text);

            taskObject.Insert();
            taskObjects.Add(taskObject);

            var taskObjectNode = tvMain.Nodes.Add(taskObject.Id.ToString(), taskObject.Name);
            taskObjectNode.Tag = taskObject.Id;
            taskObjectNode.ImageIndex = 0;
            taskObjectNode.Text = taskObject.Name;

            ShowMessage(Color.Green, $"������ {taskObject.Id} - {taskObject.Name} ��������");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTaskObject();
        }
    }
}