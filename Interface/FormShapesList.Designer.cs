using System.ComponentModel;

namespace Interface
{
    partial class FormShapesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShapesList));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Button_Up = new System.Windows.Forms.Button();
            this.Button_Down = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_DeleteFigure = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Button_AddRect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_AddTri = new System.Windows.Forms.Button();
            this.button_AddCircle = new System.Windows.Forms.Button();
            this.button_AddSquare = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Snow;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 452);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Button_Up
            // 
            this.Button_Up.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.Button_Up.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Button_Up.BackgroundImage")));
            this.Button_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_Up.FlatAppearance.BorderSize = 0;
            this.Button_Up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Up.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Up.Location = new System.Drawing.Point(17, 34);
            this.Button_Up.Name = "Button_Up";
            this.Button_Up.Size = new System.Drawing.Size(149, 44);
            this.Button_Up.TabIndex = 1;
            this.Button_Up.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Up.UseVisualStyleBackColor = false;
            // 
            // Button_Down
            // 
            this.Button_Down.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.Button_Down.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Button_Down.BackgroundImage")));
            this.Button_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Down.Location = new System.Drawing.Point(187, 34);
            this.Button_Down.Name = "Button_Down";
            this.Button_Down.Size = new System.Drawing.Size(149, 44);
            this.Button_Down.TabIndex = 2;
            this.Button_Down.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Button_DeleteFigure);
            this.groupBox1.Controls.Add(this.Button_Up);
            this.groupBox1.Controls.Add(this.Button_Down);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование фигуры";
            // 
            // Button_DeleteFigure
            // 
            this.Button_DeleteFigure.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.Button_DeleteFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeleteFigure.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Button_DeleteFigure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_DeleteFigure.Location = new System.Drawing.Point(17, 84);
            this.Button_DeleteFigure.Name = "Button_DeleteFigure";
            this.Button_DeleteFigure.Size = new System.Drawing.Size(319, 44);
            this.Button_DeleteFigure.TabIndex = 3;
            this.Button_DeleteFigure.Text = "Удалить фигуру";
            this.Button_DeleteFigure.UseMnemonic = false;
            this.Button_DeleteFigure.UseVisualStyleBackColor = false;
            this.Button_DeleteFigure.Click += new System.EventHandler(this.Button_DeleteFigure_Click);
            // 
            // Button_AddRect
            // 
            this.Button_AddRect.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.Button_AddRect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddRect.Location = new System.Drawing.Point(17, 36);
            this.Button_AddRect.Name = "Button_AddRect";
            this.Button_AddRect.Size = new System.Drawing.Size(319, 44);
            this.Button_AddRect.TabIndex = 4;
            this.Button_AddRect.Text = "Добавить прямоугольник";
            this.Button_AddRect.UseVisualStyleBackColor = false;
            this.Button_AddRect.UseWaitCursor = true;
            this.Button_AddRect.Click += new System.EventHandler(this.Button_AddRect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.Button_AddTri);
            this.groupBox2.Controls.Add(this.button_AddCircle);
            this.groupBox2.Controls.Add(this.button_AddSquare);
            this.groupBox2.Controls.Add(this.Button_AddRect);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox2.Location = new System.Drawing.Point(384, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 244);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление фигуры";
            this.groupBox2.UseWaitCursor = true;
            // 
            // Button_AddTri
            // 
            this.Button_AddTri.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.Button_AddTri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddTri.Location = new System.Drawing.Point(17, 186);
            this.Button_AddTri.Name = "Button_AddTri";
            this.Button_AddTri.Size = new System.Drawing.Size(319, 44);
            this.Button_AddTri.TabIndex = 7;
            this.Button_AddTri.Text = "Добавить треугольник";
            this.Button_AddTri.UseVisualStyleBackColor = false;
            this.Button_AddTri.UseWaitCursor = true;
            this.Button_AddTri.Click += new System.EventHandler(this.Button_AddTri_Click);
            // 
            // button_AddCircle
            // 
            this.button_AddCircle.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.button_AddCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddCircle.Location = new System.Drawing.Point(17, 136);
            this.button_AddCircle.Name = "button_AddCircle";
            this.button_AddCircle.Size = new System.Drawing.Size(319, 44);
            this.button_AddCircle.TabIndex = 6;
            this.button_AddCircle.Text = "Добавить круг";
            this.button_AddCircle.UseVisualStyleBackColor = false;
            this.button_AddCircle.UseWaitCursor = true;
            this.button_AddCircle.Click += new System.EventHandler(this.button_AddCircle_Click);
            // 
            // button_AddSquare
            // 
            this.button_AddSquare.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.button_AddSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddSquare.Location = new System.Drawing.Point(17, 86);
            this.button_AddSquare.Name = "button_AddSquare";
            this.button_AddSquare.Size = new System.Drawing.Size(319, 44);
            this.button_AddSquare.TabIndex = 5;
            this.button_AddSquare.Text = "Добавить квадрат";
            this.button_AddSquare.UseVisualStyleBackColor = false;
            this.button_AddSquare.UseWaitCursor = true;
            this.button_AddSquare.Click += new System.EventHandler(this.button_AddSquare_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.button_SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveFile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button_SaveFile.Location = new System.Drawing.Point(480, 420);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(153, 44);
            this.button_SaveFile.TabIndex = 4;
            this.button_SaveFile.Text = "Сохранить";
            this.button_SaveFile.UseVisualStyleBackColor = false;
            // 
            // FormShapesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(747, 476);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormShapesList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_AddCircle;
        private System.Windows.Forms.Button Button_AddRect;
        private System.Windows.Forms.Button button_AddSquare;
        private System.Windows.Forms.Button Button_AddTri;
        private System.Windows.Forms.Button Button_Down;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button Button_Up;

        private System.Windows.Forms.Button Button_DeleteFigure;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}