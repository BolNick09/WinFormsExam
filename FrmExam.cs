using Microsoft.Identity.Client;
using System.DirectoryServices.ActiveDirectory;
using WinFormsExam;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using Microsoft.VisualBasic.ApplicationServices;

namespace FrmExam
{
    public partial class FrmExam : Form
    {
        public List<TaskObject> taskObjects { get; set; }
        public List<WinFormsExam.Task> tasks { get; set; }
        public List<Decision> decisions { get; set; }
        public List<WinFormsExam.User> users { get; set; }

        public TaskObject SelectedTaskObject { get; set; }
        public WinFormsExam.Task SelectedTask { get; set; }
        public Decision SelectedDecision { get; set; }
        public WinFormsExam.User SelectedUser { get; set; }

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //���������� �������
            if (tbcInfo.SelectedTab == tbpObject)
            {
                if (!CheckTaskObject())
                {
                    ShowMessage(Color.Red, "��������� ��� ���� �������");
                    return;
                }
                AddTaskObject();
                //ShowMessage(Color.Green, "������ ��������");
            }
            else if (tbcInfo.SelectedTab == tbpTask)
            {
                if (tbTaskDescription.Text.IsNullOrEmpty())
                {
                    ShowMessage(Color.YellowGreen, "��������� �������� ������");
                    return;
                }
                AddTask();
                //ShowMessage(Color.Green, "������ ���������");
            }
            
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            //��������� �������
            if (tbcInfo.SelectedTab == tbpObject)
            {
                if (!CheckTaskObject())
                {
                    ShowMessage(Color.YellowGreen, "��������� ��� ���� �������");
                    return;
                }
                ModTaskObject();
                //ShowMessage(Color.Green, "������ ������");
            }
            else if (tbcInfo.SelectedTab == tbpTask)
            {
                if (tbTaskDescription.Text.IsNullOrEmpty())
                {
                    ShowMessage(Color.YellowGreen, "��������� �������� ������");
                    return;
                }
                ModTask();
                //ShowMessage(Color.Green, "������ ��������");
            }
            else if (tbcInfo.SelectedTab == tbpDecision)
            {
                ModDecision();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //�������� �������
            if (tbcInfo.SelectedTab == tbpObject)
            {
                DelTaskObject();
                //ShowMessage(Color.Green, "������ �����");
            }
            else if (tbcInfo.SelectedTab == tbpTask)
            {
                DelTask();
                //ShowMessage(Color.Green, "������ �������");
            }
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
                dtpStartDate.Value = SelectedDecision.StartDate;
                dtpEndDate.Value = SelectedDecision.EndDate;

                tbPersonName.Text = SelectedUser?.Username;

                cbbStatus.SelectedIndex = (int)SelectedDecision?.Status;
                cbbPosition.SelectedIndex = (int)SelectedUser?.UserType;

                cbbTaskManager.SelectedIndex = cbbTaskManager.Items.IndexOf(SelectedUser);
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

            cbbStatus.Items.Add("�����");
            cbbStatus.Items.Add("� ��������");
            cbbStatus.Items.Add("�������");

            cbbPosition.Items.Add("�� ���������");
            cbbPosition.Items.Add("��������");
            cbbPosition.Items.Add("������������");

            TaskObject.GetInfo(taskObjects);
            WinFormsExam.Task.GetInfo(tasks);
            Decision.GetInfo(decisions);
            WinFormsExam.User.GetInfo(users);

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

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;


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

            foreach (WinFormsExam.User user in users)
                cbbTaskManager.Items.Add(user);

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

            TaskObject taskObject = new TaskObject(tbObjectName.Text, tbAddress.Text, tbCadastralNumber.Text);

            taskObject.Insert();
            taskObjects.Add(taskObject);

            //var taskObjectNode = tvMain.Nodes.Add(taskObject.Id.ToString(), taskObject.Name);
            //taskObjectNode.Tag = taskObject.Id;
            //taskObjectNode.ImageIndex = 0;
            //taskObjectNode.Text = taskObject.Name;
            fillTvMain();

            ShowMessage(Color.Green, $"������ {taskObject.Id} - {taskObject.Name} ��������");
        }

        private void ModTaskObject()
        {
            if (SelectedTaskObject == null)
                return;
            SelectedTaskObject.Name = tbObjectName.Text;
            SelectedTaskObject.Address = tbAddress.Text;
            SelectedTaskObject.CadastralNumber = tbCadastralNumber.Text;

            SelectedTaskObject.Update();
            fillTvMain();
            ShowMessage(Color.Green, $"������ {SelectedTaskObject.Id} - {SelectedTaskObject.Name} �������");


        }

        private void DelTaskObject()
        {
            if (SelectedTaskObject == null)
                return;

            SelectedTaskObject.Delete();
            taskObjects.Remove(SelectedTaskObject);
            fillTvMain();
        }

        private void AddTask()
        {
            if (SelectedTaskObject == null)
                return;

            Decision decision = new Decision("New decision", DateTime.Now, DateTime.Now, Statuses.NEW);
            decision.Insert();
            decisions.Add(decision);

            WinFormsExam.Task task = new WinFormsExam.Task(tbTaskDescription.Text, users[0].Id, decision.Id);
            task.Insert();
            task.�onnectToObject(SelectedTaskObject.Id);

            tasks.Add(task);

            fillTvMain();
        }

        private void ModTask()
        {
            if (SelectedTaskObject == null)
                return;
            if (SelectedTask == null)
                return;

            SelectedTask.TaskDescription = tbTaskDescription.Text;
            SelectedTask.UserId = SelectedUser.Id;

            SelectedTask.Update();
            fillTvMain();

        }
        private void DelTask()
        {
            if (SelectedTaskObject == null)
                return;
            if (SelectedTask == null)
                return;

            SelectedTask.Delete();
            tasks.Remove(SelectedTask);
            fillTvMain();
        }

        private void ModDecision()
        {
            if (SelectedDecision == null) 
                return;

            SelectedDecision.DecisionDescription = tbDecisionDescription.Text;
            SelectedDecision.StartDate = dtpStartDate.Value;
            SelectedDecision.EndDate = dtpEndDate.Value;
            SelectedDecision.Status = (Statuses)cbbStatus.SelectedIndex;

            SelectedDecision.Update();
            fillTvMain();
            ShowMessage(Color.Green, "������� ���������");

        }

        private void cbbTaskManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTaskManager.SelectedItem == null)
                return;
            SelectedUser = (WinFormsExam.User)cbbTaskManager.SelectedItem;

            tbPersonName.Text = SelectedUser?.Username;
            cbbStatus.SelectedIndex = (int)SelectedDecision?.Status;
            cbbPosition.SelectedIndex = (int)SelectedUser?.UserType;

        }

        private void tbcInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcInfo.SelectedTab == tbpDecision)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            taskObjects.Clear();
            tasks.Clear();
            decisions.Clear();
            users.Clear();
            cbbTaskManager.Items.Clear();

            TaskObject.GetInfo(taskObjects);
            WinFormsExam.Task.GetInfo(tasks);
            Decision.GetInfo(decisions);
            WinFormsExam.User.GetInfo(users);

            fillTvMain();

            ShowMessage(Color.Green, "������ ���������.");
        }        
    }
}
