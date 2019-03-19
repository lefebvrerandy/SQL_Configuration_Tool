using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Configuration_Tool
{
    public partial class Form1 : Form
    {
        DataFields df = new DataFields();
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            HideErrorLabels();
            InitiateEventHandlers();
        }

        private void InitiateEventHandlers()
        {
            // Event Handler list
            // Event Handler for text field bin capacity
            tb_bin.LostFocus +=
                new System.EventHandler(BinCapacityLostFocus);
            // Event Handler for text field refill bin
            tb_refill.LostFocus +=
                new System.EventHandler(RefillBinLostFocus);
            // Event Handler for text field time scale
            tb_time.LostFocus +=
                new System.EventHandler(TimeScaleLostFocus);
            // Event Handler for combo box skill
            cb_skill.SelectedIndexChanged +=
                new System.EventHandler(ComboBoxSelectionChanged);

        }

        private void BinCapacityLostFocus(object sender, EventArgs e)   // Need to add the ability to lock characters from text fields
        {
            // Validate
            var converted = 0;
            try
            {
                converted = Int32.Parse(tb_bin.Text);
            }
            catch (Exception)
            {
                converted = -1;
            }
            if ((converted <= 0) || (converted > 20))
            {
                lb_bin.Visible = true;
            }
            else
            {
                lb_bin.Hide();
                df.BinCapacity = converted;
            }
        }

        private void RefillBinLostFocus(object sender, EventArgs e)
        {
            // Validate
            var converted = 0;
            try
            {
                converted = Int32.Parse(tb_refill.Text);
            }
            catch (Exception)
            {
                converted = -1;
            }
            if ((converted <= 0 ) || (converted > 10))
            {
                lb_refill.Visible = true;
            }
            else
            {
                lb_refill.Hide();
                df.RefillRate = converted;
            }
        }

        private void TimeScaleLostFocus(object sender, EventArgs e)
        {
            // Validate
            var converted = 0;
            try
            {
                converted = Int32.Parse(tb_time.Text);
            }
            catch (Exception)
            {
                converted = -1;
            }
            if ((converted <= 0) || (converted > 10))
            {
                lb_time.Visible = true;
            }
            else
            {
                lb_time.Hide();
                df.TimeScale = converted;
            }
        }

        private void ComboBoxSelectionChanged(object sender, EventArgs e)
        {
            // Validate
            if ((cb_skill.SelectedIndex <= -1) )
            {
                lb_skill.Visible = true;
            }
            else
            {
                lb_skill.Hide();
                df.EmployeeSkillImpact = cb_skill.SelectedItem.ToString();
            }
        }

        void PopulateComboBox()
        {
            // Load the information in the combo box
            cb_skill.Items.Add("rookie");
            cb_skill.Items.Add("average");
            cb_skill.Items.Add("experienced");
        }

        /// <summary>
        /// Hide all labels. Called at the start of the programs life cycle
        /// just to hide all the validation labels.
        /// </summary>
        void HideErrorLabels()
        {
            lb_bin.Hide();
            lb_refill.Hide();
            lb_skill.Hide();
            lb_time.Hide();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            // Check DataFields instance for filled information.
            // If properties in the Datafield instance is all filled,
            // we want to turn it into a datatable for 

            // Validate
            bool isValid = false;
            if ((df.BinCapacity != -1) && (df.RefillRate != -1) && (df.TimeScale != -1) && (df.EmployeeSkillImpact != ""))
            {
                isValid = true;
            }

            // Create Table
            if (isValid)
            {
                DataTable dt = CreateDataTable();
            }

            // Insert Table
            if (isValid)
            {
                //InsertTable(dt);
            }
        }

        private DataTable CreateDataTable()
        {
                // Here we create a DataTable with four columns.
                DataTable table = new DataTable();
                table.Columns.Add("Bin Capacity", typeof(int));
                table.Columns.Add("Refill Rate", typeof(int));
                table.Columns.Add("Time Scale", typeof(int));
                table.Columns.Add("Employee Skill Impact", typeof(string));

                // Here we add five DataRows.
                table.Rows.Add(df.BinCapacity, df.RefillRate, df.TimeScale, df.EmployeeSkillImpact);
                return table;
        }
    }
}
