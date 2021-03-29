
namespace Workers_List
{
    partial class FireWorker
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.dtpToFireData = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbToFireData = new System.Windows.Forms.Label();
            this.btnId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(124, 157);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(289, 143);
            this.rtbComments.TabIndex = 30;
            this.rtbComments.Text = "";
            // 
            // dtpToFireData
            // 
            this.dtpToFireData.Location = new System.Drawing.Point(124, 117);
            this.dtpToFireData.Name = "dtpToFireData";
            this.dtpToFireData.Size = new System.Drawing.Size(289, 20);
            this.dtpToFireData.TabIndex = 29;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 53);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(289, 20);
            this.tbName.TabIndex = 28;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(124, 83);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(289, 20);
            this.tbSurname.TabIndex = 27;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 56);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 25;
            this.lbName.Text = "Imię";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(12, 86);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(53, 13);
            this.lbSurname.TabIndex = 24;
            this.lbSurname.Text = "Nazwisko";
            // 
            // lbToFireData
            // 
            this.lbToFireData.AutoSize = true;
            this.lbToFireData.Location = new System.Drawing.Point(12, 123);
            this.lbToFireData.Name = "lbToFireData";
            this.lbToFireData.Size = new System.Drawing.Size(82, 13);
            this.lbToFireData.TabIndex = 23;
            this.lbToFireData.Text = "Data zwolnienia";
            // 
            // btnId
            // 
            this.btnId.AutoSize = true;
            this.btnId.Location = new System.Drawing.Point(12, 27);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(96, 13);
            this.btnId.TabIndex = 20;
            this.btnId.Text = "Numer pracownika";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(124, 20);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(289, 20);
            this.tbId.TabIndex = 19;
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(12, 157);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 21;
            this.lbComments.Text = "Uwagi:";
            // 
            // FireWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.dtpToFireData);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbToFireData);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.tbId);
            this.Name = "FireWorker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.DateTimePicker dtpToFireData;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbToFireData;
        private System.Windows.Forms.Label btnId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbComments;
    }
}