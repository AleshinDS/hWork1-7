
namespace CheckNum
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblCountInfo = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.InputNumTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(345, 52);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(158, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(194, 31);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Угадай число";
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // lblCountInfo
            // 
            this.lblCountInfo.AutoSize = true;
            this.lblCountInfo.Location = new System.Drawing.Point(67, 108);
            this.lblCountInfo.Name = "lblCountInfo";
            this.lblCountInfo.Size = new System.Drawing.Size(130, 13);
            this.lblCountInfo.TabIndex = 2;
            this.lblCountInfo.Text = "Использовано попыток:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(342, 108);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(4, 108);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(13, 13);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "0";
            this.lblTask.Visible = false;
            this.lblTask.Click += new System.EventHandler(this.lblTask_Click);
            // 
            // InputNumTextbox
            // 
            this.InputNumTextbox.Location = new System.Drawing.Point(97, 52);
            this.InputNumTextbox.Name = "InputNumTextbox";
            this.InputNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.InputNumTextbox.TabIndex = 5;
            this.InputNumTextbox.TextChanged += new System.EventHandler(this.InputNumTextbox_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputNumTextbox);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCountInfo);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnCheck);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(520, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblCountInfo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox InputNumTextbox;
    }
}
