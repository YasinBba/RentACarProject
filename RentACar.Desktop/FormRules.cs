using System;
using System.Windows.Forms;
using RentACar.BLL;
using RentACar.DLLModel.Model;

namespace RentACar.Desktop
{
    public partial class FormRules : Form
    {
        public FormRules()
        {
            InitializeComponent();
        }
        RuleManagment ruleManagement = new RuleManagment();
        private void FormRules_Load(object sender, EventArgs e)
        {
            dataGridViewAllRules.DataSource = ruleManagement.GetAllRules();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Id = 1; // Assuming new rule, so ID is 0
            rules.RuleName = textBoxRuleName.Text;
            rules.RuleDescription = textBoxRuleDescription.Text;
            rules.RuleDuration = Convert.ToDateTime(dateTimePickerRuleDuration.Text);
            rules.RulePrice = textBoxRulePrice.Text;
            rules.Description = "null";
            rules.RentalCarId = 0; // Assuming no specific rental car ID for this rule



            rules.CreateDate = DateTime.Now;
            rules.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            rules.UpdateDate = DateTime.Now;
            rules.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            rules.IsActive = "1";



            var result = ruleManagement.AddRule(rules);
            dataGridViewAllRules.DataSource = ruleManagement.GetAllRules();
            MessageBox.Show(result);

        }

        private RuleManagment GetRuleManagement()
        {
            return ruleManagement;
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Id = Convert.ToInt32(dataGridViewAllRules.CurrentRow.Cells[0].Value);
            rules.RuleName = textBoxRuleName.Text;
            rules.RuleDescription = textBoxRuleDescription.Text;
            rules.RuleDuration = Convert.ToDateTime(dateTimePickerRuleDuration.Text);
            rules.RulePrice = textBoxRulePrice.Text;
            rules.UpdateDate = DateTime.Now;
            rules.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            rules.Description = "null";
            rules.RentalCarId = 0; // Assuming no specific rental car ID for this rule
            rules.IsActive = "1";
            ruleManagement.UpdateRule(rules);
            dataGridViewAllRules.DataSource = ruleManagement.GetAllRules();
            MessageBox.Show("Kural Güncellendi");



        }

        private void dataGridViewAllRules_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRuleName.Text = dataGridViewAllRules.CurrentRow.Cells[1].Value.ToString();
            textBoxRuleDescription.Text = dataGridViewAllRules.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerRuleDuration.Text = dataGridViewAllRules.CurrentRow.Cells[3].Value.ToString();
            textBoxRulePrice.Text = dataGridViewAllRules.CurrentRow.Cells[4].Value.ToString();

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAllRules.CurrentRow.Cells[0].Value);
            ruleManagement.DeleteRule(id);
            dataGridViewAllRules.DataSource = ruleManagement.GetAllRules();
            MessageBox.Show("Kural Silindi");

        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            textBoxRuleName.Clear();
            textBoxRuleDescription.Clear();
            dateTimePickerRuleDuration.ResetText();
            textBoxRulePrice.Clear();

        }
    }
}
