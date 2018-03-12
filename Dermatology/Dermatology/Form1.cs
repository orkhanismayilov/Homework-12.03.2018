using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dermatology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Doctors List
        List<Doctors> Docs = new List<Doctors>();

        // Add Doctor Function
        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            // Date Time Variables
            DateTime ShiftStart = new DateTime();
            DateTime ShiftEnd = new DateTime();

            // Shift Start Time Check Function
            bool CheckShiftStart()
            {
                if (txtShiftStart.Text.Length == 5 && txtShiftStart.Text[2].Equals(':') && txtShiftStart.Text != "")
                {
                    if(DateTime.TryParseExact(txtShiftStart.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out ShiftStart))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Shift Start Time! Please, enter as hh:mm!", "Wrong data");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Shift Start Time! Please, enter as hh:mm!", "Wrong data");
                    return false;
                }
            }
            
            // Shift End Time Check Function
            bool CheckShiftEnd()
            {
                if (txtShiftEnd.Text.Length == 5 && txtShiftEnd.Text[2].Equals(':') && txtShiftEnd.Text != "")
                {
                    if (DateTime.TryParseExact(txtShiftEnd.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out ShiftEnd))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Shift End Time! Please, enter as hh:mm!", "Wrong data");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Shift End Time! Please, enter as hh:mm!", "Wrong data");
                    return false;
                }
            }

            // Adding Doctor
            if (txtFullname.Text != "")
            {
                // Using Input Check Functions
                if (!CheckShiftStart())
                {
                    return;
                }
                if (!CheckShiftEnd())
                {
                    return;
                }

                Doctors a = new Doctors(txtFullname.Text);

                // Checked Days Check
                if (clbWorkDays.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please, choose the workdays!", "Error");
                    return;
                }

                // Adding Process
                foreach (var item in clbWorkDays.CheckedItems)
                {
                    a.WorkDays.Add(Convert.ToByte(item));
                }
                a.StartTime = ShiftStart;
                a.EndTime = ShiftEnd;
                Docs.Add(a);

                // Clearing Fields
                if (Docs.Contains(a))
                {
                    txtFullname.Text = "";
                    txtShiftStart.Text = "";
                    txtShiftEnd.Text = "";
                    clbWorkDays.ClearSelected();
                    for (int i = 0; i < clbWorkDays.Items.Count; i++)
                    {
                        clbWorkDays.SetItemChecked(i, false);
                    }
                    MessageBox.Show("Doctor " + a.FullName + " successfully added.", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please, enter Fullname of the doctor.");
                return;
            }
        }

        // Find Doctor Function
        private void btnFind_Click(object sender, EventArgs e)
        {
            // Docs List Checking
            if (Docs.Count != 0)
            {
                lstFoundDocs.Visible = false;
                lstFoundDocs.Clear();
                string day = cmbFindDay.SelectedItem.ToString();
                DateTime FindTime = new DateTime();

                // Find Time Check Function
                bool CheckFindTime()
                {
                    if (txtFindHour.Text.Length == 5 && txtFindHour.Text[2].Equals(':') && txtFindHour.Text != "")
                    {
                        if (DateTime.TryParseExact(txtFindHour.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out FindTime))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Entered Time! Please, enter as hh:mm!", "Wrong data");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Entered Time! Please, enter as hh:mm!", "Wrong data");
                        return false;
                    }
                }

                // Using Find Time Check Function
                if (!CheckFindTime())
                {
                    return;
                }
                
                // Finding Doctors
                foreach (Doctors item in Docs)
                {
                    if (item.WorkDays.Contains(byte.Parse(day)) && item.StartTime <= FindTime && item.EndTime >= FindTime )
                    {
                        lstFoundDocs.Visible = true;
                        lstFoundDocs.Items.Add(item.FullName);

                        // Clearing Fields
                        cmbFindDay.SelectedValue = "";
                        txtFindHour.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sorry. We do not have doctors for this time. Try another time.", "No Doctors");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no any doctor in database.", "Error");
            }
        }
    }
}
