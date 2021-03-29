
namespace Workers_List
{
    partial class AddEditWorker
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnId = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbEmployData = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpEmployData = new System.Windows.Forms.DateTimePicker();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(124, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(289, 20);
            this.tbId.TabIndex = 0;
            // 
            // btnId
            // 
            this.btnId.AutoSize = true;
            this.btnId.Location = new System.Drawing.Point(12, 19);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(96, 13);
            this.btnId.TabIndex = 1;
            this.btnId.Text = "Numer pracownika";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(12, 176);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 2;
            this.lbComments.Text = "Uwagi:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(12, 147);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(106, 13);
            this.lbSalary.TabIndex = 3;
            this.lbSalary.Text = "Wysokość zarobków";
            // 
            // lbEmployData
            // 
            this.lbEmployData.AutoSize = true;
            this.lbEmployData.Location = new System.Drawing.Point(12, 108);
            this.lbEmployData.Name = "lbEmployData";
            this.lbEmployData.Size = new System.Drawing.Size(90, 13);
            this.lbEmployData.TabIndex = 5;
            this.lbEmployData.Text = "Data zatrudnienia";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(12, 78);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(53, 13);
            this.lbSurname.TabIndex = 6;
            this.lbSurname.Text = "Nazwisko";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Imię";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(124, 140);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(289, 20);
            this.tbSalary.TabIndex = 9;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(124, 75);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(289, 20);
            this.tbSurname.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 20);
            this.tbName.TabIndex = 13;
            // 
            // dtpEmployData
            // 
            this.dtpEmployData.Location = new System.Drawing.Point(124, 108);
            this.dtpEmployData.Name = "dtpEmployData";
            this.dtpEmployData.Size = new System.Drawing.Size(289, 20);
            this.dtpEmployData.TabIndex = 14;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(124, 176);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(289, 143);
            this.rtbComments.TabIndex = 16;
            this.rtbComments.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 475);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.dtpEmployData);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbEmployData);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.tbId);
            this.Name = "AddEditWorker";
            this.Text = "AddEditWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label btnId;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbEmployData;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpEmployData;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}