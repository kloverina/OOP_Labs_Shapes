namespace Interface
{
    partial class FormOpenFile
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
            this.Button_CreateFile = new System.Windows.Forms.Button();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Button_CreateFile
            // 
            this.Button_CreateFile.BackColor = System.Drawing.SystemColors.Menu;
            this.Button_CreateFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Button_CreateFile.Location = new System.Drawing.Point(240, 100);
            this.Button_CreateFile.Name = "Button_CreateFile";
            this.Button_CreateFile.Size = new System.Drawing.Size(248, 53);
            this.Button_CreateFile.TabIndex = 0;
            this.Button_CreateFile.Text = "Создать новый файл";
            this.Button_CreateFile.UseVisualStyleBackColor = false;
            this.Button_CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.BackColor = System.Drawing.SystemColors.Menu;
            this.Button_OpenFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Button_OpenFile.Location = new System.Drawing.Point(240, 224);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(248, 53);
            this.Button_OpenFile.TabIndex = 1;
            this.Button_OpenFile.Text = "Открыть файл";
            this.Button_OpenFile.UseVisualStyleBackColor = false;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(762, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_OpenFile);
            this.Controls.Add(this.Button_CreateFile);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormOpenFile";
            this.Text = "Фигуры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Button Button_CreateFile;
        private System.Windows.Forms.Button Button_OpenFile;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}