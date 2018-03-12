namespace Dermatology
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbWorkDays = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShiftStart = new System.Windows.Forms.TextBox();
            this.txtShiftEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFindDay = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.lstFoundDocs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtFullname
            // 
            this.txtFullname.AccessibleDescription = "";
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFullname.Location = new System.Drawing.Point(12, 67);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(215, 20);
            this.txtFullname.TabIndex = 0;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Location = new System.Drawing.Point(12, 51);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(91, 13);
            this.lblDocName.TabIndex = 1;
            this.lblDocName.Text = "Doctor\'s Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Week Days";
            // 
            // clbWorkDays
            // 
            this.clbWorkDays.CheckOnClick = true;
            this.clbWorkDays.FormattingEnabled = true;
            this.clbWorkDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.clbWorkDays.Location = new System.Drawing.Point(12, 121);
            this.clbWorkDays.Name = "clbWorkDays";
            this.clbWorkDays.Size = new System.Drawing.Size(60, 109);
            this.clbWorkDays.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shift Start Time [hh:mm]";
            // 
            // txtShiftStart
            // 
            this.txtShiftStart.Location = new System.Drawing.Point(101, 121);
            this.txtShiftStart.Name = "txtShiftStart";
            this.txtShiftStart.Size = new System.Drawing.Size(116, 20);
            this.txtShiftStart.TabIndex = 7;
            // 
            // txtShiftEnd
            // 
            this.txtShiftEnd.Location = new System.Drawing.Point(101, 177);
            this.txtShiftEnd.Name = "txtShiftEnd";
            this.txtShiftEnd.Size = new System.Drawing.Size(116, 20);
            this.txtShiftEnd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shift End Time [hh:mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Find Doctor";
            // 
            // txtFindHour
            // 
            this.txtFindHour.Location = new System.Drawing.Point(434, 67);
            this.txtFindHour.Name = "txtFindHour";
            this.txtFindHour.Size = new System.Drawing.Size(116, 20);
            this.txtFindHour.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time [hh:mm]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Week Day";
            // 
            // cmbFindDay
            // 
            this.cmbFindDay.FormattingEnabled = true;
            this.cmbFindDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbFindDay.Location = new System.Drawing.Point(353, 67);
            this.cmbFindDay.Name = "cmbFindDay";
            this.cmbFindDay.Size = new System.Drawing.Size(55, 21);
            this.cmbFindDay.TabIndex = 20;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(353, 104);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(12, 250);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(75, 23);
            this.btnAddDoc.TabIndex = 25;
            this.btnAddDoc.Text = "Add Doctor";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // lstFoundDocs
            // 
            this.lstFoundDocs.Location = new System.Drawing.Point(353, 133);
            this.lstFoundDocs.Name = "lstFoundDocs";
            this.lstFoundDocs.Size = new System.Drawing.Size(267, 140);
            this.lstFoundDocs.TabIndex = 26;
            this.lstFoundDocs.UseCompatibleStateImageBehavior = false;
            this.lstFoundDocs.View = System.Windows.Forms.View.List;
            this.lstFoundDocs.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 283);
            this.Controls.Add(this.lstFoundDocs);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbFindDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFindHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShiftEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShiftStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbWorkDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDocName);
            this.Controls.Add(this.txtFullname);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding and Finding Docs in ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbWorkDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShiftStart;
        private System.Windows.Forms.TextBox txtShiftEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFindHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFindDay;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.ListView lstFoundDocs;
    }
}

